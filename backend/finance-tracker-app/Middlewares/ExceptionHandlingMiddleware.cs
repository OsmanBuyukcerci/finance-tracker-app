using System.Text.Json;
using Microsoft.AspNetCore.Hosting;

namespace finance_tracker_app.Middlewares
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _Next;
        private readonly ILogger<ExceptionHandlingMiddleware> _Logger;
        private readonly IWebHostEnvironment _Env;

        public ExceptionHandlingMiddleware(
            RequestDelegate next, 
            ILogger<ExceptionHandlingMiddleware> logger,
            IWebHostEnvironment env)
        {
            _Next = next;
            _Logger = logger;
            _Env = env;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _Next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            _Logger.LogError(ex, "An unhandled exception occurred");

            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Response.ContentType = "application/json";

            var response = new
            {
                StatusCode = context.Response.StatusCode,
                Message = "An unexpected error occurred. Please try again later.",
                Details = _Env.IsDevelopment() ? ex.Message : null
            };

            var json = JsonSerializer.Serialize(response);

            return context.Response.WriteAsync(json);
        }
    }
}
