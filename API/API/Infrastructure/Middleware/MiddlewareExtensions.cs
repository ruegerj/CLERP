using Microsoft.AspNetCore.Builder;

namespace CLERP.API.Infrastructure.Middleware
{
    public static class MiddlewareExtensions
    {
        /// <summary>
        /// Extension method which registers all custom middleware in the correct order
        /// </summary>
        /// <param name="app"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlingMiddleware>();

            return app;
        }
    }
}
