using Microsoft.Extensions.DependencyInjection;

//namespace Microsoft.AspNetCore.Routing;

namespace razormy.MyMiddleware.Routing;

/// <summary>
/// A marker class used to determine if all the routing services were added
/// to the <see cref="IServiceCollection"/> before routing is configured.
/// </summary>
internal sealed class MyRoutingMarkerService
{
}
