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
        // Validate header "xHuyQuery"
        if (!context.Request.Headers.TryGetValue("xHuyQuery", out var headerValue) || headerValue != "v")
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