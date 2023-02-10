namespace AspNetCore6.MinimalApi.Study.Middleware
{
    public class LoggerMiddleware
    {
        //  External non-terminal middleware uses the RequestDelegate for next invocation
        //  External terminal middleware doesn't use RequestDelegate
        private readonly RequestDelegate _next;

        //  This will be injected by the DI system
        public LoggerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        //  This name can be Invoke or InvokeAsync
        //  It will be called with current HttpContext
        public async Task InvokeAsync(HttpContext context)
        {
            //  We see the call to next as it is a non-terminal middleware
            //  For terminal middleware, there is no next
            Console.WriteLine("External MW: Pre Next");
            await _next.Invoke(context);
            Console.WriteLine("External MW: Post Next");
        }
    }
}
