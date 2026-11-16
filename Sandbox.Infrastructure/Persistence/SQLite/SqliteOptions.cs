using System;

namespace Sandbox.Infrastructure;

public class SqliteOptions
{
    public const string Section = "SQLite";
    
    public string ConnectionString { get; }
}