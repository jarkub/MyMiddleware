//namespace Microsoft.AspNetCore.HttpsPolicy

namespace razormy.MyMiddleware.HttpsPolicy;

public static /*partial*/ class MyHttpsLoggingExtensions
{
    private static readonly Action<ILogger, string, Exception?> __MyRedirectingToHttpsCallback =
        LoggerMessage.Define<string>(LogLevel.Debug, new EventId(1, "RedirectingToHttps"), "Redirecting to '{redirect}'.", new LogDefineOptions() { SkipEnabledCheck = true });

    public static /*partial*/ void MyRedirectingToHttps(this ILogger logger, string redirect)
    {
        if (logger.IsEnabled(LogLevel.Debug))
        {
            __MyRedirectingToHttpsCallback(logger, redirect, null);
        }
    }

    private static readonly Action<ILogger, int, Exception?> __MyPortLoadedFromConfigCallback =
        LoggerMessage.Define<int>(LogLevel.Debug, new EventId(2, "PortLoadedFromConfig"), "Https port '{port}' loaded from configuration.", new LogDefineOptions() { SkipEnabledCheck = true });

    public static /*partial*/ void MyPortLoadedFromConfig(this ILogger logger, int port)
    {
               if (logger.IsEnabled(LogLevel.Debug))
        {
            __MyPortLoadedFromConfigCallback(logger, port, null);
        }
    }

    private static readonly Action<ILogger, Exception?> __MyFailedToDeterminePortCallback =
        LoggerMessage.Define(LogLevel.Warning, new EventId(3, "FailedToDeterminePort"), "Failed to determine the https port for redirect.", new LogDefineOptions() { SkipEnabledCheck = true });

    public static /*partial*/ void MyFailedToDeterminePort(this ILogger logger)
    {
        if (logger.IsEnabled(LogLevel.Warning))
        {
            __MyFailedToDeterminePortCallback(logger, null);
        }
    }

    private static readonly Action<ILogger, int, Exception?> __MyPortFromServerCallback =
        LoggerMessage.Define<int>(LogLevel.Debug, new EventId(5, "PortFromServer"), "Https port '{httpsPort}' discovered from server endpoints.", new LogDefineOptions() { SkipEnabledCheck = true });

    public static /*partial*/ void MyPortFromServer(this ILogger logger, int httpsPort)
    {
        if (logger.IsEnabled(LogLevel.Debug))
        {
            __MyPortFromServerCallback(logger, httpsPort, null);
        }
    }
}