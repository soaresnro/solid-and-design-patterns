using System.Diagnostics.CodeAnalysis;

namespace Domain.Settings;

[ExcludeFromCodeCoverage]
public class DbSettings
{
    public string ConnectionString { get; set; } = string.Empty;
}