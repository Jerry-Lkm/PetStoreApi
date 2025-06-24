using System.Net.Http.Headers;
using System.Text;

namespace PetStore.Api;

public class BasicAuthMiddleware(RequestDelegate next)
{
    private readonly RequestDelegate _next = next;
    private const string Username = "testuser";
    private const string Password = "Test@123";

    public async Task InvokeAsync(HttpContext context)
    {
        if (!context.Request.Headers.ContainsKey("Authorization"))
        {
            context.Response.Headers.WWWAuthenticate = "Basic";
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            await context.Response.WriteAsync("Missing Authorization Header");
            return;
        }

        var authHeader = AuthenticationHeaderValue.Parse(context.Request.Headers.Authorization!);
        if (authHeader.Scheme != "Basic")
        {
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            await context.Response.WriteAsync("Invalid Authorization Scheme");
            return;
        }

        var credentialBytes = Convert.FromBase64String(authHeader.Parameter!);
        var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':', 2);
        if (credentials.Length != 2 || credentials[0] != Username || credentials[1] != Password)
        {
            context.Response.Headers.WWWAuthenticate = "Basic";
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            await context.Response.WriteAsync("Invalid Username or Password");
            return;
        }

        await _next(context);
    }
}
