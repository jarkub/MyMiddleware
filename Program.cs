

using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Options;

using razormy.MyMiddleware.HttpsPolicy;
using razormy.MyMiddleware.Builder;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpsRedirection((HttpsRedirectionOptions options) =>
{
    options.HttpsPort = null;
    options.RedirectStatusCode = -1;
});
// Add services to the container.
//builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
app.MyUseHttpsRedirection();

app.UseRouting();
//app.MyUseRouting();

//app.UseAuthorization();

app.MapStaticAssets();

//app.MapRazorPages()
//   .WithStaticAssets();

app.Run();
