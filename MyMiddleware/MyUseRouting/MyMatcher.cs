using Microsoft.AspNetCore.Http;

//namespace Microsoft.AspNetCore.Routing.Matching;

namespace razormy.MyMiddleware.Routing.Matching;

/// <summary>
/// An interface for components that can select an <see cref="Endpoint"/> given the current request, as part
/// of the execution of <see cref="MyEndpointRoutingMiddleware"/>.
/// </summary>
internal abstract class MyMatcher
{
    /// <summary>
    /// Attempts to asynchronously select an <see cref="Endpoint"/> for the current request.
    /// </summary>
    /// <param name="httpContext">The <see cref="HttpContext"/> associated with the current request.</param>
    /// <returns>A <see cref="Task"/> which represents the asynchronous completion of the operation.</returns>
    public abstract Task MatchAsync(HttpContext httpContext);
}
