using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

public class Startup
{
    public void Configure(IApplicationBuilder app)
    {
        app.Run(async context =>
        {
            var bytes = System.Text.Encoding.ASCII.GetBytes("Hello");
            await context.Response.Body.WriteAsync(bytes, 0, bytes.Length);
        });

    }
}