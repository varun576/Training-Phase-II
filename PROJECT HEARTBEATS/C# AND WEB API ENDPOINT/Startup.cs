    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.OpenApi.Models;
   // using BLOODBANK2.Data;
    using BLOODBANK2.Services;
    using BLOODBANK2.Context;

using BLOODBANK2.Services.Interface;
using Microsoft.AspNetCore.Cors.Infrastructure;

namespace BLOODBANK2
{

        public class Startup
        {
            public Startup(IConfiguration configuration)
            {
                Configuration = configuration;
            }

            public IConfiguration Configuration { get; }

            public void ConfigureServices(IServiceCollection services)
            {
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("SQLConnection")));
            services.AddScoped<DonorService>();
            services.AddScoped<RecipientService>();

           
          services.AddCors(options =>
           {
               options.AddPolicy("CorsPolicy", builder =>
               {
                   builder.AllowAnyHeader();
                   builder.AllowAnyMethod();
                   builder.AllowAnyOrigin();
               });
           });
             services.AddScoped<IDonorService, DonorService>();
            services.AddScoped<IRecipientService, RecipientService>();
            //services.AddScoped<IReportService, ReportService>();
            //services.AddScoped<IRequestService, RequestService>();

            services.AddControllers();

                services.AddSwaggerGen(c =>
                {
                    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Blood Bank Management System", Version = "v1" });
                });
            }

            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                    app.UseSwagger();
                    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Blood Bank Management System v1"));
                }

            app.UseHttpsRedirection();

          app.UseCors("CorsPolicy");

                app.UseAuthorization();
            app.UseRouting();
                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                });
            }
        }
    }


