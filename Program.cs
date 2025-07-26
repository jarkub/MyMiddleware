

using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Options;

using razormy.MyExperiments;
using razormy.MyMiddleware.Builder;
using razormy.MyMiddleware.HttpsPolicy;

//string[]? Args;
//string? EnvironmentName;
//string? ApplicationName;
//string? ContentRootPath;
//string? WebRootPath;


//{
//    Args = args,
//    EnvironmentName = EnvironmentName,
//    ApplicationName = ApplicationName,
//    ContentRootPath = ContentRootPath,
//    WebRootPath = WebRootPath
//};

var builder = WebApplication.CreateBuilder(args);
//builder.Logging.AddDebug();
//builder.Services.AddLogging(loggingBuilder =>
//{
//    loggingBuilder.AddConsole();
//});
var loggerFactory = LoggerFactory.Create(builder =>
{
    builder.AddConsole(); // Configure your desired logging providers
});

var logger = loggerFactory.CreateLogger<Program>();
logger.LogInformation("Application starting up.");
//var builder = WebApplication.CreateSlimBuilder(args);
//var builder = WebApplication.CreateSlimBuilder();
//builder.Logging.AddConsole();
var alogger = GetServiceFromCollection<Microsoft.Extensions.Logging.ILogger>(builder.Services);
var aloggerfactory = GetServiceFromCollection<Microsoft.Extensions.Logging.ILoggerFactory>(builder.Services);
var alogger2 = builder.Services.LastOrDefault(d => d.ServiceType == typeof(Microsoft.Extensions.Logging.ILogger))
    ?.ImplementationInstance as Microsoft.Extensions.Logging.ILogger;
var aloggerfactory2 = builder.Services.LastOrDefault(d => d.ServiceType == typeof(Microsoft.Extensions.Logging.ILoggerFactory))
    ?.ImplementationInstance as Microsoft.Extensions.Logging.ILoggerFactory;
var manager = GetServiceFromCollection<ApplicationPartManager>(builder.Services);
/*
var options = new WebApplicationOptions() { Args = args };
var builder = WebApplication.CreateEmptyBuilder(options);
*/

builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true;
    options.LowercaseQueryStrings = true;
});

builder.Services.AddSingleton<razormy.MyMiddleware.Routing.MyRoutingMarkerService>();

//builder.Services.AddSingleton<IConfigureOptions<HttpsRedirectionOptions>, MyHttpsRedirectionOptions>();

//builder.Configuration.AddEnvironmentVariables(prefix: "MONNIT_");

//builder.Configuration.Environment
//builder.Services.AddHttpsRedirection((HttpsRedirectionOptions options) =>
//{
//    options.HttpsPort = null;
//    options.RedirectStatusCode = -1;
//});
// Add services to the container.
//builder.Services.AddRazorPages();

var app = builder.Build();

app.MyMiddlewareExperiment1(false);
app.MyMiddlewareExperiment2();
app.MyMiddlewareExperiment3();
app.MyMiddlewareExperiment4();
app.MyMiddlewareExperiment5();

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.MyUseHttpsRedirection();

app.UseRouting();


//app.MyUseRouting();

//app.UseAuthorization();

app.MapStaticAssets();

//app.MapRazorPages()
//   .WithStaticAssets();

app.Run();

static T? GetServiceFromCollection<T>(IServiceCollection services)
{
    return (T?)services
        .LastOrDefault(d => d.ServiceType == typeof(T))
        ?.ImplementationInstance;
}