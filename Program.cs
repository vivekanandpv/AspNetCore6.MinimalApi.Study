namespace AspNetCore6.MinimalApi.Study
{
    public class Program
    {
        //  Primary documentation: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis?view=aspnetcore-7.0
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            //  Please refer to: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/index/_static/request-delegate-pipeline.png?view=aspnetcore-7.0

            //  Non-terminal middleware use Use()
            app.Use(async (context, next) =>
            {
                Console.WriteLine("MW1: Pre Next");
                await next.Invoke();
                Console.WriteLine("MW1: Post Next");
            });

            app.Use(async (context, next) =>
            {
                Console.WriteLine("MW2: Pre Next");
                await next.Invoke();
                Console.WriteLine("MW2: Post Next");
            });

            //  Terminal middleware use Run()
            app.Run(async context =>
            {
                //  context is the HttpContext, which houses both Request and Response
                Console.WriteLine("Terminal MW");
                await context.Response.WriteAsync("Hello, world!");
            });

            app.Run();
        }
    }
}