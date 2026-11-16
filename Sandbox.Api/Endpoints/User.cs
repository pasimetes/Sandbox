using System;

namespace Sandbox.Api.EndPoints;

public static class User
{
    public static RouteGroupBuilder RegisterUser(this RouteGroupBuilder builder)
    {
        var user = builder
            .MapGroup("/users")
            .RequireAuthorization();

        user.MapGet("/list", (CancellationToken ct) => Results.Ok);

        user.MapPost("/create", (CancellationToken ct) => Results.Ok);
        
        return builder;
    }
}