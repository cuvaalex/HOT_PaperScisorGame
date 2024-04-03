namespace HOT.Assessment.RockPaperScissor.Architecture.Test.ArchitectureRules;

using System.Runtime.CompilerServices;

public static class Namespaces
{
    public const string Domain = "Domain";
    public const string UseCases = "UseCases";
    public const string Exceptions = "Exceptions";
    public const string Infrastructure = "Infrastructure";
    public static readonly string? CompilerServices = typeof(RuntimeHelpers).Namespace;   
}