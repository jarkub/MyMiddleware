using System.Diagnostics;

namespace razormy.MyExperiments;

public static class MyMiddlewareExperiments
{
    public static IApplicationBuilder MyMiddlewareExperiment1(this IApplicationBuilder builder, bool slim)
    {
        Debug.Assert(slim, "should only be called with slim: true");
        Debug.Assert(!slim, "should only be called with slim: false");

        return builder;
    }

    public static IApplicationBuilder MyMiddlewareExperiment2(this IApplicationBuilder builder)
    {
        var configuration = new ConfigurationManager();

        configuration.AddEnvironmentVariables(prefix: "ASPNETCORE_");

        return builder;
    }

    public static IApplicationBuilder MyMiddlewareExperiment3(this IApplicationBuilder builder)
    {
        var configuration = new ConfigurationManager();

        configuration.AddInMemoryCollection(new[]
        {
            new KeyValuePair<string, string?>(nameof(MyMiddlewareExperiments), nameof(MyMiddlewareExperiment3)),
        });
        return builder;
    }

    public static IApplicationBuilder MyMiddlewareExperiment4(this IApplicationBuilder builder)
    {
        Dictionary<string, string> args = new()
        {
            { "AStringProperty", "Hello World" },
            { "AnIntProperty", "42" }
        };
        
        var options = new AnObject();
        options.MapInPlaceExtension(args);

        return builder;
    }

    public static IApplicationBuilder MyMiddlewareExperiment5(this IApplicationBuilder builder)
    {
        Dictionary<string, string> args = new()
        {
            { "AStringProperty", "Hello World" },
            { "AnIntProperty", "42" }
        };

        var options = new AnObject();
        
        MapInPlaceMethod(options, args);

        return builder;
    }

    public static void MapInPlaceExtension(this AnObject obj, IEnumerable<KeyValuePair<string, string>> args)
    {
        MapInPlaceMethod(obj, args);
    }

    public static void MapInPlaceMethod(AnObject obj, IEnumerable<KeyValuePair<string, string>> args)
    {
        if (args.Any(kvp => kvp.Key == "AStringProperty"))
        {
            string v = args.First(kvp => kvp.Key == "AStringProperty").Value;
            obj.AStringProperty = v;
        }
        if (args.Any(kvp => kvp.Key == "AnIntProperty"))
        {
            string v = args.First(kvp => kvp.Key == "AnIntProperty").Value;
            if (int.TryParse(v, out int intValue))
            {
                obj.AnIntProperty = intValue;
            }
            else
            {
                throw new ArgumentException($"Invalid value for AnIntProperty: {v}");
            }
        }
    }
}

public class AnObject
{
    public string? AStringProperty { get; set; }
    public int AnIntProperty { get; set; }
}