using System;

namespace Sandbox.Infrastructure;

public class JwtOptions
{
    public const string Section = "Jwt";
    
    public string Issuer { get; }
    
    public string Audience { get; }
    
    public string SigningKey { get; }
}