using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

public class RequestValidationMiddleware
{
    private readonly RequestDelegate _next;
    private const int MaxBodySize = 10 * 1024; // 10KB

    public RequestValidationMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {

        var path = context.Request.Path;

        // Bypass Swagger, favicon, health, preflight
        if (path.StartsWithSegments("/swagger") ||
            path.StartsWithSegments("/favicon.ico") ||
            path.StartsWithSegments("/health") ||
            string.Equals(context.Request.Method, "OPTIONS", StringComparison.OrdinalIgnoreCase))
        {
            await _next(context);
            return;
        }

        // Validate header "xHuyQuery"
        if (!context.Request.Headers.TryGetValue("xHuyQuery", out var headerValue))
        {
            context.Response.StatusCode = StatusCodes.Status400BadRequest;
            await context.Response.WriteAsync("Missing or invalid xHuyQuery header.");
            return;
        }

        // Validate body size
        if (context.Request.ContentLength.HasValue && context.Request.ContentLength.Value > MaxBodySize)
        {
            context.Response.StatusCode = StatusCodes.Status413PayloadTooLarge;
            await context.Response.WriteAsync("Request body too large (>10KB).");
            return;
        }

        await _next(context);
    }
}