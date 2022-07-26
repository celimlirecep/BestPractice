using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestPractice.Api.Extensions
{
    public static class HealthCheckConfigureExtension
    {
        public static IApplicationBuilder UseCustomHealthCheck( this IApplicationBuilder app)
        {
            //uygulamama devamlı istekte bulunarak uygulamamın sağlıklı bir şekilde çalışıp alışmadığını kntrol eder
            app.UseHealthChecks("/api/health", new Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions()
            {
                ResponseWriter = async (context, report) =>
                {
                    await context.Response.WriteAsync("OK");
                }
            });
            return app;
        }
    }
}
