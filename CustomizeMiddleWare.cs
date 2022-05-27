using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class CustomizeMiddleWare : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("<html><body>Incomming Request<br></body></html>");
            next(context);
            await context.Response.WriteAsync("<html><body>Incomming Response</body></html>");
         
        }
    }
}
