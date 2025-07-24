
//namespace Microsoft.AspNetCore.Routing.ShortCircuit;

namespace razormy.MyMiddleware.Routing.ShortCircuit;

internal sealed class MyShortCircuitMetadata
{
    public int? StatusCode { get; }

    public MyShortCircuitMetadata(int? statusCode)
    {
        StatusCode = statusCode;
    }
}
