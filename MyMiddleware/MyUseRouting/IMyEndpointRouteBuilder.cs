using Microsoft.AspNetCore.Builder;

using razormy.MyMiddleware.Builder;

//namespace Microsoft.AspNetCore.Routing;

namespace razormy.MyMiddleware.Routing;

/// <summary>
/// Defines a contract for a route builder in an application. A route builder specifies the routes for
/// an application.
/// </summary>
public interface IMyEndpointRouteBuilder
{
    /// <summary>
    /// Creates a new <see cref="IApplicationBuilder"/>.
    /// </summary>
    /// <returns>The new <see cref="IApplicationBuilder"/>.</returns>
    IApplicationBuilder CreateApplicationBuilder();

    /// <summary>
    /// Gets the <see cref="IServiceProvider"/> used to resolve services for routes.
    /// </summary>
    IServiceProvider ServiceProvider { get; }

    /// <summary>
    /// Gets the endpoint data sources configured in the builder.
    /// </summary>
    ICollection<MyEndpointDataSource> DataSources { get; }
}
