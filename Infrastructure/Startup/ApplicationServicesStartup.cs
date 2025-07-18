using H3.Scenario.Generator.API.Infrastructure.Services;
using Serilog;
namespace H3.Scenario.Generator.API.Infrastructure.Startup;

public static class ApplicationServicesStartup
{
    public static WebApplicationBuilder AddCustomServices(this WebApplicationBuilder builder)
    {
        //builder.Services.AddScoped<IPasswordGenerator, PasswordGenerator>();
        builder.Services.AddScoped<IRepository, JSonRepository>();
        
        return builder;
    }

    public static WebApplicationBuilder AddBuiltInServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers().AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumConverter());
        });
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddHttpContextAccessor();

        builder.Services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy",

                policy =>
                    policy
                        .SetIsOriginAllowed(_ => true)
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials());
        });

        return builder;
    }

    public static WebApplicationBuilder AddLogger(this WebApplicationBuilder builder){
        


        return builder;

    }
}
