using System.Diagnostics;
using System.Text.Json;

namespace EFCore.Api.Middlewares
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestLoggingMiddleware> _logger;

        public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            var stopwatch = Stopwatch.StartNew();
            var method = context.Request.Method;
            var path = context.Request.Path;
            int statusCode = 200;
            string error = null;

            try
            {
                await _next(context);
                statusCode = context.Response.StatusCode;
            }
            catch (Exception ex)
            {
                statusCode = 500;
                error = ex.Message;
                _logger.LogError(ex, "Unhandled exception");
                throw;
            }
            finally
            {
                stopwatch.Stop();
                // Kiểm tra ModelState lỗi
                if (context.Items.ContainsKey("ModelStateErrors"))
                {
                    var errors = context.Items["ModelStateErrors"];
                    _logger.LogWarning("ModelState errors: {Errors}", JsonSerializer.Serialize(errors));
                }
                _logger.LogInformation(
                    "Method: {Method}, Path: {Path}, StatusCode: {StatusCode}, Error: {Error}, ExecutionTime: {ExecutionTime}ms",
                    method, path, statusCode, error, stopwatch.ElapsedMilliseconds
                );
            }
        }
    }

}
