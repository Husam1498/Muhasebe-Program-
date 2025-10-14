namespace OMPS.WebApi.Midleware
{
    public static class ExceptionMidlewareExtensions
    {
        public static IApplicationBuilder UseExceptionMidleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ExceptionMidleware>();
        }
    }
}
