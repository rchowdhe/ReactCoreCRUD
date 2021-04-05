using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace ReactCoreCRUD
{
    public static class SwaggerServiceExtensions
    {
        private static readonly string CrudApiVersion = "v1";
        private static readonly string CrudApiName = "CRUD API";
        private static readonly string CrudApiDesc = "This API expose endpoints to perform CRUD operation for '<b>react-core-crud</b>' application";

        public static IServiceCollection AddSwaggerDocumentation(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(CrudApiVersion, new OpenApiInfo
                {
                    Version = CrudApiVersion,
                    Title = CrudApiName,
                    Description = CrudApiDesc,
                    Contact = new OpenApiContact
                    {
                        Name = "Rajiv Chowdhery",
                        Email = "rajiv.chowdhery@gmail.com",
                    }
                });

                OpenApiSecurityScheme securityScheme = new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"",
                    Name = "Authorization",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey
                };

                OpenApiSecurityRequirement security = new OpenApiSecurityRequirement()
                {
                    {securityScheme, new string[] { }},
                };

                c.AddSecurityDefinition("Bearer", securityScheme);

                c.AddSecurityRequirement(security);
            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", CrudApiName);
                c.DocumentTitle = CrudApiName;
                c.DocExpansion(DocExpansion.None);
            });
            return app;
        }
    }
}
