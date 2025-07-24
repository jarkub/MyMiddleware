using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.HttpsPolicy;

namespace razormy;

public static class MyHttpsRedirectionBuilderExtensions
{
    /// <summary>
    /// Adds middleware for redirecting HTTP Requests to HTTPS.
    /// </summary>
    /// <param name="app">The <see cref="IApplicationBuilder"/> instance this method extends.</param>
    /// <returns>The <see cref="IApplicationBuilder"/> for HttpsRedirection.</returns>
    public static IApplicationBuilder UseMyHttpsRedirection(this IApplicationBuilder app)
    {
        ArgumentNullException.ThrowIfNull(app);

        var serverAddressFeature = app.ServerFeatures.Get<IServerAddressesFeature>();
        if (serverAddressFeature != null)
        {
            app.UseMiddleware<MyHttpsRedirectionMiddleware>(serverAddressFeature);
        }
        else
        {
            app.UseMiddleware<MyHttpsRedirectionMiddleware>();
        }
        serverAddressFeature = app.ServerFeatures.Get<IServerAddressesFeature>();
        return app;
    }
}
