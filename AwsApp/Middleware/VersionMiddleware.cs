namespace AwsApp.Middleware
{
    public class VersionMiddleware
    {

        private RequestDelegate _next { get; set; }
        private DateTime _version = DateTime.UtcNow;
        private ILogger _logger;

        public VersionMiddleware(RequestDelegate next, ILogger logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            httpContext.Response.Headers["version_time"] = _version.ToString();

            await _next(httpContext);
        }
    }
}
