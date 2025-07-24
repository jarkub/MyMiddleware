using Microsoft.AspNetCore.Routing;

//namespace Microsoft.AspNetCore.Routing.Matching;

namespace razormy.MyMiddleware.Routing.Matching;

internal abstract class MyMatcherFactory
{
    public abstract MyMatcher CreateMatcher(MyEndpointDataSource dataSource);
}
