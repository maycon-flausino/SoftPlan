using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SoftPlan.Api.InterestCalculator.Repositories;
using Swashbuckle.AspNetCore.Swagger;

namespace SoftPlan.Api.InterestCalculator
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSingleton<IInterestRepository, InterestRepository>();

            services.AddSwaggerGen(s => { s.SwaggerDoc("v1", new 
                Info {
                Title = "API Calcula Juros",
                Version = "v1",                
                Description = "Calculation Api Rest with ASP.NET Core",
                Contact = new Contact
                {
                    Name = "Maycon Flausino",
                    Url = "https://github.com/maycon-flausino"
                }

            }); });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(s => { s.SwaggerEndpoint("/swagger/v1/swagger.json", "API Calcula Juros"); });
        }
    }
}
