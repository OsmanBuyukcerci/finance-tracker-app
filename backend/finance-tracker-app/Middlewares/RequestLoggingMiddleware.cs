namespace finance_tracker_app.Middlewares
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _Next;
        private readonly ILogger<RequestLoggingMiddleware> _Logger;

        public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
        {
            _Next = next;
            _Logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Log the request details
            _Logger.LogInformation("Handling request: {Method} {Path}", context.Request.Method, context.Request.Path);
            // Call the next middleware in the pipeline
            await _Next(context);
            // Log the response details
            _Logger.LogInformation("Finished handling request. Response status code: {StatusCode}", context.Response.StatusCode);
        }
    }
}
