namespace AspNetCore6.MinimalApi.Study
{
    public class Program
    {
        //  Primary documentation: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis?view=aspnetcore-7.0
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //  builder is created with defaults
            //  One such default is the ability access appsettings.json
            //  This file is external to the Asp.Net Core system
            //  But is represented by IConfiguration

            //  To fetch simple values such as string, int, double, boolean, etc (not complex objects or arrays)
            var allowedHosts = builder.Configuration.GetValue<string>("AllowedHosts");

            //  To drill-down
            var defaultLogLevel = builder.Configuration.GetValue<string>("Logging:LogLevel:Default");

            //  For complex values (arrays and objects)
            var cities = builder.Configuration.GetSection("Cities").Get<string[]>();

            var app = builder.Build();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"Hello World >> {allowedHosts} >> {defaultLogLevel}{Environment.NewLine}");
                await context.Response.WriteAsync(string.Join(";", cities));
            });

            app.Run();
        }
    }
}