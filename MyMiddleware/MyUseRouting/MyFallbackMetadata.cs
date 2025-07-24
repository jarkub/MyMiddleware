//namespace Microsoft.AspNetCore.Routing;

namespace razormy.MyMiddleware.Routing;

internal sealed class MyFallbackMetadata
{
    public static readonly MyFallbackMetadata Instance = new MyFallbackMetadata();

    private MyFallbackMetadata()
    {
    }
}
