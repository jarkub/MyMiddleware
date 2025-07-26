namespace razormy.MyExamples;

public static class MyMiddlewareExamples
{
    // This is a placeholder for any experimental middleware logic
    // You can add your custom middleware logic here
    public static IApplicationBuilder MyExample1(this IApplicationBuilder builder)
    {
        // For example, logging, custom headers, etc.
        // Example: Adding a custom header
        builder.Use(async (context, next) =>
        {
            context.Response.Headers.Add("X-My-Custom-Header", "MyValue");
            await next.Invoke();
        });
        return builder;
    }

    public static IApplicationBuilder MyExample2(this IApplicationBuilder builder)
    {
        // For example, modifying the request or response, etc.
        // Example: Logging the request path
        builder.Use(async (context, next) =>
        {
            Console.WriteLine($"Request Path: {context.Request.Path}");
            await next.Invoke();
        });
        return builder;
    }

    public static IApplicationBuilder MyExample3(this IApplicationBuilder builder)
    {                
        // For example, handling specific routes or conditions
        // Example: Conditional response based on request path
        builder.Use(async (context, next) =>
        {
            if (context.Request.Path.StartsWithSegments("/experimental"))
            {
                context.Response.StatusCode = 200;
                await context.Response.WriteAsync("This is an experimental endpoint.");
            }
            else
            {
                await next.Invoke();
            }
        });
        return builder;
    }

    public static IApplicationBuilder MyExample4(this IApplicationBuilder builder)
    {
        // For example, handling specific headers or query parameters
        // Example: Checking for a specific query parameter
        builder.Use(async (context, next) =>
        {
            if (context.Request.Query.ContainsKey("experimental"))
            {
                context.Response.StatusCode = 200;
                await context.Response.WriteAsync("Experimental feature enabled.");
            }
            else
            {
                await next.Invoke();
            }
        });
        return builder;
    }

    public static IApplicationBuilder MyExample5(this IApplicationBuilder builder)
    {
        // For example, modifying the response based on certain conditions
        // Example: Modifying the response body
        builder.Use(async (context, next) =>
        {
            await next.Invoke();
            if (context.Response.StatusCode == 404)
            {
                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync("Custom 404 Not Found message.");
            }
        });
        return builder;
    }

    public static IApplicationBuilder MyExample6(this IApplicationBuilder builder)
    {
        // For example, handling specific content types or request methods
        // Example: Handling only GET requests
        builder.Use(async (context, next) =>
        {
            if (context.Request.Method == "GET")
            {
                await next.Invoke();
            }
            else
            {
                context.Response.StatusCode = 405; // Method Not Allowed
                await context.Response.WriteAsync("Only GET requests are allowed.");
            }
        });
        return builder;
    }

    public static IApplicationBuilder MyExample7(this IApplicationBuilder builder)
    {
        // For example, handling specific authentication or authorization scenarios
        // Example: Simple authentication check
        builder.Use(async (context, next) =>
        {
            if (context.Request.Headers.ContainsKey("Authorization"))
            {
                await next.Invoke();
            }
            else
            {
                context.Response.StatusCode = 401; // Unauthorized
                await context.Response.WriteAsync("Authorization header is required.");
            }
        });
        return builder;
    }

    public static IApplicationBuilder MyExample8(this IApplicationBuilder builder)
    {
        // For example, handling specific caching or response compression scenarios
        // Example: Simple response caching
        builder.Use(async (context, next) =>
        {
            if (context.Request.Headers.ContainsKey("If-None-Match"))
            {
                context.Response.StatusCode = 304; // Not Modified
            }
            else
            {
                await next.Invoke();

                if (context.Response.Headers.ContainsKey("Cache-Control"))
                {
                    // If Cache-Control header already exists, append to it
                    context.Response.Headers.Append("Cache-Control", "public,max-age=3600");
                }
                else
                {
                    // Otherwise, set the Cache-Control header
                    context.Response.Headers["Cache-Control"] = "public,max-age=3600";
                }
            }
        });
        return builder;
    }

    public static IApplicationBuilder MyExample9(this IApplicationBuilder builder)
    {
        // For example, handling specific logging or monitoring scenarios
        // Example: Simple request logging
        builder.Use(async (context, next) =>
        {
            Console.WriteLine($"Request Method: {context.Request.Method}, Request Path: {context.Request.Path}");
            await next.Invoke();
        });
        return builder;
    }


    public static IApplicationBuilder MyExample10(this IApplicationBuilder builder)
    {
        // For example, handling specific error handling or fallback scenarios
        // Example: Simple error handling
        builder.Use(async (context, next) =>
        {
            try
            {
                await next.Invoke();
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 500; // Internal Server Error
                await context.Response.WriteAsync($"An error occurred: {ex.Message}");
            }
        });
        return builder;
    }

    public static IApplicationBuilder MyExample11(this IApplicationBuilder builder)
    {
        // For example, handling specific data processing or transformation scenarios
        // Example: Simple data transformation
        builder.Use(async (context, next) =>
        {
            if (context.Request.ContentType == "application/json")
            {
                // Process JSON data here
                await next.Invoke();
            }
            else
            {
                context.Response.StatusCode = 415; // Unsupported Media Type
                await context.Response.WriteAsync("Only application/json content type is supported.");
            }
        });
        return builder;
    }

    public static IApplicationBuilder MyExample12(this IApplicationBuilder builder)
    {
        // For example, handling specific security or validation scenarios
        // Example: Simple input validation
        builder.Use(async (context, next) =>
        {
            if (context.Request.Query.ContainsKey("valid"))
            {
                await next.Invoke();
            }
            else
            {
                context.Response.StatusCode = 400; // Bad Request
                await context.Response.WriteAsync("Invalid request parameters.");
            }
        });
        return builder;
    }

    public static IApplicationBuilder MyExample13(this IApplicationBuilder builder)
    {
        // For example, handling specific response formatting or serialization scenarios
        // Example: Simple response formatting
        builder.Use(async (context, next) =>
        {
            await next.Invoke();
            if (context.Response.ContentType == "text/plain")
            {
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync("{\"message\":\"Response formatted as JSON.\"}");
            }
        });
        return builder;
    }

    public static IApplicationBuilder MyExample14(this IApplicationBuilder builder)
    {
        // For example, handling specific asynchronous operations or background tasks
        // Example: Simple background task simulation
        builder.Use(async (context, next) =>
        {
            await next.Invoke();
            // Simulate a background task
            Task.Run(() => Console.WriteLine("Background task executed after response."));
        });
        return builder;
    }

    public static IApplicationBuilder MyExample15(this IApplicationBuilder builder)
    {
        // For example, handling specific internationalization or localization scenarios
        // Example: Simple localization based on query parameter
        builder.Use(async (context, next) =>
        {
            if (context.Request.Query.ContainsKey("lang"))
            {
                var lang = context.Request.Query["lang"].ToString();
                context.Response.Headers.Add("Content-Language", lang);
            }
            await next.Invoke();
        });
        return builder;
    }

    public static IApplicationBuilder MyExample16(this IApplicationBuilder builder)
    {
        // For example, handling specific user session or state management scenarios
        // Example: Simple session management
        builder.Use(async (context, next) =>
        {
            if (context.Request.Cookies.ContainsKey("session_id"))
            {
                // Simulate session validation
                await next.Invoke();
            }
            else
            {
                context.Response.StatusCode = 403; // Forbidden
                await context.Response.WriteAsync("Session not found.");
            }
        });
        return builder;
    }

    public static IApplicationBuilder MyExample17(this IApplicationBuilder builder)
    {
        // For example, handling specific data caching or storage scenarios
        // Example: Simple in-memory caching
        builder.Use(async (context, next) =>
        {
            if (context.Request.Query.ContainsKey("cache"))
            {
                context.Response.Headers.Add("X-Cache", "HIT");
                await context.Response.WriteAsync("Cached response.");
            }
            else
            {
                await next.Invoke();
                context.Response.Headers.Add("X-Cache", "MISS");
            }
        });
        return builder;
    }

    public static IApplicationBuilder MyExample18(this IApplicationBuilder builder)
    {
        // For example, handling specific data validation or sanitization scenarios
        // Example: Simple input sanitization
        builder.Use(async (context, next) =>
        {
            if (context.Request.Query.ContainsKey("sanitize"))
            {
                var sanitizedValue = context.Request.Query["sanitize"].ToString().Replace("<", "").Replace(">", "");
                context.Request.Query = new QueryCollection(new Dictionary<string, Microsoft.Extensions.Primitives.StringValues>
                {
                    { "sanitize", sanitizedValue }
                });
            }
            await next.Invoke();
        });
        return builder;
    }

    public static IApplicationBuilder MyExample19(this IApplicationBuilder builder)
    {
        // For example, handling specific data transformation or enrichment scenarios
        // Example: Simple data enrichment
        builder.Use(async (context, next) =>
        {
            if (context.Request.Query.ContainsKey("enrich"))
            {
                context.Response.Headers.Add("X-Enriched-Data", "EnrichedValue");
            }
            await next.Invoke();
        });
        return builder;
    }

    public static IApplicationBuilder MyExample20(this IApplicationBuilder builder)
    {
        // For example, handling specific data aggregation or summarization scenarios
        // Example: Simple data aggregation
        builder.Use(async (context, next) =>
        {
            if (context.Request.Query.ContainsKey("aggregate"))
            {
                context.Response.Headers.Add("X-Aggregated-Data", "AggregatedValue");
            }
            await next.Invoke();
        });
        return builder;
    }

    public static IApplicationBuilder MyExample21(this IApplicationBuilder builder)
    {
        // For example, handling specific data filtering or selection scenarios
        // Example: Simple data filtering
        builder.Use(async (context, next) =>
        {
            if (context.Request.Query.ContainsKey("filter"))
            {
                context.Response.Headers.Add("X-Filtered-Data", "FilteredValue");
            }
            await next.Invoke();
        });
        return builder;
    }
}