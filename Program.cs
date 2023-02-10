namespace AspNetCore6.MinimalApi.Study
{
    public class Program
    {
        //  Primary documentation: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis?view=aspnetcore-7.0
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            //  Terminal middleware use Run()
            app.Run(async context =>
            {
                //  context is the HttpContext, which houses both Request and Response
                await context.Response.WriteAsync("Hello, world!");
            });

            app.Run();
        }
    }
}