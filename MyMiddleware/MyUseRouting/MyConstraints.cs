
#if !COMPONENTS
using Microsoft.AspNetCore.Http;
#else
using Microsoft.AspNetCore.Components.Routing;
#endif

//namespace Microsoft.AspNetCore.Routing.Constraints;

namespace razormy.MyMiddleware.Routing;

#if !COMPONENTS
internal sealed class MyRegexErrorStubRouteConstraint : IRouteConstraint
#else
internal sealed class RegexErrorStubRouteConstraint : IRouteConstraint, IParameterPolicy
#endif
{
    public MyRegexErrorStubRouteConstraint(string _)
    {
        throw new InvalidOperationException(MyResources.RegexRouteContraint_NotConfigured);
    }

#if !COMPONENTS
    bool IRouteConstraint.Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
#else
    bool IRouteConstraint.Match(string routeKey, RouteValueDictionary values)
#endif
    {
        // Should never get called, but is same as throw in constructor in case constructor is changed.
        throw new InvalidOperationException(MyResources.RegexRouteContraint_NotConfigured);
    }
}
