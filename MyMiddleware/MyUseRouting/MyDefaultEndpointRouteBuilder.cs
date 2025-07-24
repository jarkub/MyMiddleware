using Microsoft.AspNetCore.Builder;
using razormy.MyMiddleware.Routing;
//namespace Microsoft.AspNetCore.Builder;

namespace razormy.MyMiddleware.Builder;

internal sealed class MyDefaultEndpointRouteBuilder : IMyEndpointRouteBuilder
{
    public MyDefaultEndpointRouteBuilder(IApplicationBuilder applicationBuilder)
    {
        ApplicationBuilder = applicationBuilder ?? throw new ArgumentNullException(nameof(applicationBuilder));
        DataSources = new List<MyEndpointDataSource>();
    }

    public IApplicationBuilder ApplicationBuilder { get; }

    public IApplicationBuilder CreateApplicationBuilder() => ApplicationBuilder.New();

    public ICollection<MyEndpointDataSource> DataSources { get; }

    public IServiceProvider ServiceProvider => ApplicationBuilder.ApplicationServices;
}
