using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BF.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Microsoft.IdentityModel.Logging;

using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace BF
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }
        //Para conectarse desde cualquier dominio
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            //
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            
            services.AddDbContext<Models.Opotunidades.db_oportunidades>(
                op => op.UseSqlServer(Configuration.GetConnectionString("BD_OPORTUNIDADES")));
            services.AddDbContext<Models.Staffing.db_staffing>(
                op => op.UseSqlServer(Configuration.GetConnectionString("BD_STAFFING")));

            //

            //Para utilizar los sp
            services.AddSingleton(_ => Configuration);
            ////Para conectarse desde cualquier dominio
            services.AddCors(option =>
            {
                option.AddPolicy(MyAllowSpecificOrigins, builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
            {
                opt.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
                {
                    // DATA DE VALIDACIÓN
                    ValidIssuer = "YOU_ISSUER_VALUE",
                    ValidAudience = "YOUR_AUDIENCE_VALUE",
                    // QUÉ SE VA A VALIDAR
                    ValidateAudience = true,
                    ValidateIssuer = true,
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = true,
                    RequireExpirationTime = true,
                    IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("this is my custom Secret key for authnetication"))
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            ////Para conectarse desde cualquier dominio
            app.UseAuthentication();
            app.UseCors(MyAllowSpecificOrigins);

            app.UseMvc();

            //Para UploadFile
            app.UseStaticFiles();

            //Seccion ingresada para configurar las rutas!!!
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: "api", template: "api/{controller}/{action}/{id?}");
            });
        }

    }
}
