using System;

namespace Sandbox.Api.EndPoints;

public static class Auth
{
    public static RouteGroupBuilder RegisterAuth(this RouteGroupBuilder builder)
    {
        var auth = builder
            .MapGroup("/auth")
            .RequireAuthorization();

        auth.MapPost("/sign-in", (CancellationToken ct) => Results.Ok)
             .AllowAnonymous();

        auth.MapPost("/sign-up", (CancellationToken ct) => Results.Ok)
             .AllowAnonymous();
             
         auth.MapGet("/sign-out", (CancellationToken ct) => Results.Ok); 
         
        return builder;
    }
}