using System;

namespace Sandbox.Api.EndPoints;

public static class Party
{
    public static RouteGroupBuilder RegisterParty(this RouteGroupBuilder builder)
    {
        var party = builder
            .MapGroup("/parties")
            .RequireAuthorization();

        party.MapGet("/list", (CancellationToken ct) => Results.Ok);

        party.MapPost("/create", (CancellationToken ct) => Results.Ok);
        
        return builder;
    }
}