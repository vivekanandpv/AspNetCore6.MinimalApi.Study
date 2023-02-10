using AspNetCore6.MinimalApi.Study.Models;

namespace AspNetCore6.MinimalApi.Study
{
    public class Program
    {
        //  Primary documentation: https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis?view=aspnetcore-7.0
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //  It is better to access the complex structures with type-safe way
            //  Create required model classes with public properties
            //  The model classes must have parameter
            var person = builder.Configuration.GetSection("Person").Get<Person>();

            var app = builder.Build();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync(person.ToString());
            });

            app.Run();
        }
    }
}