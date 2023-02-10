namespace AspNetCore6.MinimalApi.Study
{
    public class Program
    {
        //  Primary documentation: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis?view=aspnetcore-7.0
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //  Controllers are dependencies for the framework
            //  They must be configured in the DI container,
            //  before they can be used
            builder.Services.AddControllers();

            var app = builder.Build();

            //  Attach controllers as the middleware
            app.MapControllers();

            app.Run();
        }
    }
}