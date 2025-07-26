namespace razormy.MyExamples;

public static class MyHttpContextExamples
{
    // This class can be used to group various examples of middleware usage.
    // You can add methods here that demonstrate different middleware functionalities,
    // such as logging, authentication, or custom request handling.
    
    // Example method for a simple logging middleware
    public static void LogRequest(HttpContext context)
    {
        Console.WriteLine($"Request made to: {context.Request.Path}");
    }

    // Example method for a custom authentication middleware
    public static void LogResponse(HttpContext context) {
        Console.WriteLine($"Response sent with status code: {context.Response.StatusCode}");
    }

    // Example method for a custom error handling middleware
    public static void HandleError(HttpContext context, Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");
        context.Response.StatusCode = 500; // Internal Server Error
        context.Response.ContentType = "application/json";
        context.Response.WriteAsync("{\"error\":\"An unexpected error occurred.\"}");
    }

    // Example method for a custom response transformation middleware
    public static void TransformResponse(HttpContext context)
    {
        if (context.Response.StatusCode == 200)
        {
            context.Response.ContentType = "application/json";
            context.Response.WriteAsync("{\"message\":\"Success\"}");
        }
        else
        {
            context.Response.ContentType = "application/json";
            context.Response.WriteAsync("{\"error\":\"An error occurred\"}");
        }
    }

    // You can add more methods here to demonstrate different middleware functionalities.
    // Example method for a custom request validation middleware
    public static void ValidateRequest(HttpContext context)
    {
        if (string.IsNullOrEmpty(context.Request.Query["requiredParam"]))
        {
            context.Response.StatusCode = 400; // Bad Request
            context.Response.ContentType = "application/json";
            context.Response.WriteAsync("{\"error\":\"Missing required parameter\"}");
        }
        else
        {
            // Proceed with the request processing
            Console.WriteLine("Request is valid.");
        }
    }

    // Example method for a custom response caching middleware
    public static void CacheResponse(HttpContext context)
    {
        // This is a placeholder for caching logic
        // You can implement your caching strategy here
        // For example, storing the response in memory or a distributed cache
        Console.WriteLine("Caching response for future requests.");
    }

    // Example method for a custom request logging middleware
    public static void LogRequestDetails(HttpContext context)
    {
        Console.WriteLine($"Request Method: {context.Request.Method}");
        Console.WriteLine($"Request Path: {context.Request.Path}");
        Console.WriteLine($"Request Query: {context.Request.QueryString}");
    }
}