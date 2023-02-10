namespace AspNetCore6.MinimalApi.Study
{
    public class Program
    {
        //  Primary documentation: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis?view=aspnetcore-7.0
        public static void Main(string[] args)
        {
            //  though not recommended, it is possible to create
            //  the application directly without the builder
            var app = WebApplication.Create(args);

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}