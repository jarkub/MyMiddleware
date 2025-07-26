using razormy.MyMiddleware.Builder;

namespace razormy.MyMiddleware;

public static class MyMiddlewareExtensions
{
    /// <summary>
    /// Adds a <see cref="MyEndpointRoutingMiddleware"/> middleware to the specified <see cref="IApplicationBuilder"/>.
    /// </summary>
    /// <param name="builder">The <see cref="IApplicationBuilder"/> to add the middleware to.</param>
    /// <returns>A reference to this instance after the operation has completed.</returns>
    public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder builder)
    {
        builder.MyUseHttpsRedirection();

        builder.MyUseRouting();

        return builder;
    }

    
}