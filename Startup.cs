using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CityInfoApi
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                .AddMvcOptions((action)=> 
                {
                    action.EnableEndpointRouting = false;
                    action.OutputFormatters.Add(new XmlDataContractSerializerOutputFormatter());

                
                })
                .AddJsonOptions((option)=> 
                { 
                    option.JsonSerializerOptions.WriteIndented = true;
                    option.JsonSerializerOptions.PropertyNamingPolicy = null;
                });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseMvc();
            app.UseStatusCodePages();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        throw new Exception("Exception while run");
            //        //await context.Response.WriteAsync("Hello World!");
            //    });
            //});
        }
    }
}
