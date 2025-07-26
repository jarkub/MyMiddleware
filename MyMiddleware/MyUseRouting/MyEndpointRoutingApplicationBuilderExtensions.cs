using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

using razormy.MyMiddleware.Routing;

//namespace Microsoft.AspNetCore.Builder;

namespace razormy.MyMiddleware.Builder;

/// <summary>
/// Contains extensions for configuring routing on an <see cref="IApplicationBuilder"/>.
/// </summary>
public static class MyEndpointRoutingApplicationBuilderExtensions
{
    private const string MyEndpointRouteBuilder = "__MyEndpointRouteBuilder";
    private const string MyGlobalEndpointRouteBuilderKey = "__MyGlobalEndpointRouteBuilder";
    private const string MyUseRoutingKey = "__MyUseRouting";

    /// <summary>
    /// Adds a <see cref="EndpointRoutingMiddleware"/> middleware to the specified <see cref="IApplicationBuilder"/>.
    /// </summary>
    /// <param name="builder">The <see cref="IApplicationBuilder"/> to add the middleware to.</param>
    /// <returns>A reference to this instance after the operation has completed.</returns>
    /// <remarks>
    /// <para>
    /// A call to <see cref="MyUseRouting(IApplicationBuilder)"/> must be followed by a call to
    /// <see cref="UseEndpoints(IApplicationBuilder, Action{IMyEndpointRouteBuilder})"/> for the same <see cref="IApplicationBuilder"/>
    /// instance.
    /// </para>
    /// <para>
    /// The <see cref="EndpointRoutingMiddleware"/> defines a point in the middleware pipeline where routing decisions are
    /// made, and an <see cref="Endpoint"/> is associated with the <see cref="HttpContext"/>. The <see cref="MyEndpointMiddleware"/>
    /// defines a point in the middleware pipeline where the current <see cref="Endpoint"/> is executed. Middleware between
    /// the <see cref="EndpointRoutingMiddleware"/> and <see cref="MyEndpointMiddleware"/> may observe or change the
    /// <see cref="Endpoint"/> associated with the <see cref="HttpContext"/>.
    /// </para>
    /// </remarks>
    public static IApplicationBuilder MyUseRouting(this IApplicationBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);

        VerifyRoutingServicesAreRegistered(builder);

        IMyEndpointRouteBuilder endpointRouteBuilder;
        if (builder.Properties.TryGetValue(MyGlobalEndpointRouteBuilderKey, out var obj))
        {
            endpointRouteBuilder = (IMyEndpointRouteBuilder)obj!;
            // Let interested parties know if UseRouting() was called while a global route builder was set
            builder.Properties[MyEndpointRouteBuilder] = endpointRouteBuilder;
        }
        else
        {
            endpointRouteBuilder = new MyDefaultEndpointRouteBuilder(builder);
            builder.Properties[MyEndpointRouteBuilder] = endpointRouteBuilder;
        }

        // Add UseRouting function to properties so that middleware that can't reference UseRouting directly can call UseRouting via this property
        // This is part of the global endpoint route builder concept
        builder.Properties.TryAdd(MyUseRoutingKey, (object)MyUseRouting);

        return builder.UseMiddleware<MyEndpointRoutingMiddleware>(endpointRouteBuilder);
    }

    /// <summary>
    /// Adds a <see cref="MyEndpointMiddleware"/> middleware to the specified <see cref="IApplicationBuilder"/>
    /// with the <see cref="MyEndpointDataSource"/> instances built from configured <see cref="IMyEndpointRouteBuilder"/>.
    /// The <see cref="MyEndpointMiddleware"/> will execute the <see cref="Endpoint"/> associated with the current
    /// request.
    /// </summary>
    /// <param name="builder">The <see cref="IApplicationBuilder"/> to add the middleware to.</param>
    /// <param name="configure">An <see cref="Action{IMyEndpointRouteBuilder}"/> to configure the provided <see cref="IMyEndpointRouteBuilder"/>.</param>
    /// <returns>A reference to this instance after the operation has completed.</returns>
    /// <remarks>
    /// <para>
    /// A call to <see cref="UseEndpoints(IApplicationBuilder, Action{IMyEndpointRouteBuilder})"/> must be preceded by a call to
    /// <see cref="MyUseRouting(IApplicationBuilder)"/> for the same <see cref="IApplicationBuilder"/>
    /// instance.
    /// </para>
    /// <para>
    /// The <see cref="EndpointRoutingMiddleware"/> defines a point in the middleware pipeline where routing decisions are
    /// made, and an <see cref="Endpoint"/> is associated with the <see cref="HttpContext"/>. The <see cref="MyEndpointMiddleware"/>
    /// defines a point in the middleware pipeline where the current <see cref="Endpoint"/> is executed. Middleware between
    /// the <see cref="EndpointRoutingMiddleware"/> and <see cref="MyEndpointMiddleware"/> may observe or change the
    /// <see cref="Endpoint"/> associated with the <see cref="HttpContext"/>.
    /// </para>
    /// </remarks>
    public static IApplicationBuilder UseEndpoints(this IApplicationBuilder builder, Action<IMyEndpointRouteBuilder> configure)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentNullException.ThrowIfNull(configure);

        VerifyRoutingServicesAreRegistered(builder);

        VerifyEndpointRoutingMiddlewareIsRegistered(builder, out var endpointRouteBuilder);

        configure(endpointRouteBuilder);

        // Yes, this mutates an IOptions. We're registering data sources in a global collection which
        // can be used for discovery of endpoints or URL generation.
        //
        // Each middleware gets its own collection of data sources, and all of those data sources also
        // get added to a global collection.
        var routeOptions = builder.ApplicationServices.GetRequiredService<IOptions<MyRouteOptions>>();
        foreach (var dataSource in endpointRouteBuilder.DataSources)
        {
            //if (!routeOptions.Value.EndpointDataSources.Contains(dataSource))
            //{
            //    routeOptions.Value.EndpointDataSources.Add(dataSource);
            //}
        }

        return builder.UseMiddleware<MyEndpointMiddleware>();
    }

    private static void VerifyRoutingServicesAreRegistered(IApplicationBuilder app)
    {
        // Verify if AddRouting was done before calling UseEndpointRouting/UseEndpoint
        // We use the RoutingMarkerService to make sure if all the services were added.
        if (app.ApplicationServices.GetService(typeof(MyRoutingMarkerService)) == null)
        {
            throw new InvalidOperationException(MyResources.FormatUnableToFindServices(
                nameof(IServiceCollection),
                nameof(RoutingServiceCollectionExtensions.AddRouting),
                "ConfigureServices(...)"));
        }
    }

    private static void VerifyEndpointRoutingMiddlewareIsRegistered(IApplicationBuilder app, out IMyEndpointRouteBuilder endpointRouteBuilder)
    {
        if (!app.Properties.TryGetValue(MyEndpointRouteBuilder, out var obj))
        {
            var message =
                $"{nameof(MyEndpointRoutingMiddleware)} matches endpoints setup by {nameof(MyEndpointMiddleware)} and so must be added to the request " +
                $"execution pipeline before {nameof(MyEndpointMiddleware)}. " +
                $"Please add {nameof(MyEndpointRoutingMiddleware)} by calling '{nameof(IApplicationBuilder)}.{nameof(MyUseRouting)}' inside the call " +
                $"to 'Configure(...)' in the application startup code.";
            throw new InvalidOperationException(message);
        }

        endpointRouteBuilder = (IMyEndpointRouteBuilder)obj!;

        // This check handles the case where Map or something else that forks the pipeline is called between the two
        // routing middleware.
        if (endpointRouteBuilder is MyDefaultEndpointRouteBuilder defaultRouteBuilder && !object.ReferenceEquals(app, defaultRouteBuilder.ApplicationBuilder))
        {
            var message =
                $"The {nameof(MyEndpointRoutingMiddleware)} and {nameof(MyEndpointMiddleware)} must be added to the same {nameof(IApplicationBuilder)} instance. " +
                $"To use Endpoint Routing with 'Map(...)', make sure to call '{nameof(IApplicationBuilder)}.{nameof(MyUseRouting)}' before " +
                $"'{nameof(IApplicationBuilder)}.{nameof(UseEndpoints)}' for each branch of the middleware pipeline.";
            throw new InvalidOperationException(message);
        }
    }
}
