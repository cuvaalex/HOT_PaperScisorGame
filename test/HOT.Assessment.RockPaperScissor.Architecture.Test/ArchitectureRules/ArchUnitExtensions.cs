using HOT.Assessment.RockPaperScissor.Core.UseCases;

namespace HOT.Assessment.RockPaperScissor.Architecture.Test.ArchitectureRules;

using ArchUnitNET.Domain;
using ArchUnitNET.Fluent;
using ArchUnitNET.Loader;
using ArchUnitNET.xUnit;



public static class ArchUnitExtensions
{
    private static readonly Architecture Architecture =
        new ArchLoader()
            .LoadAssemblies(typeof(PaperRockScissorUseCase).Assembly)
            .Build();

    public static void Check(this IArchRule rule)
        => rule.Check(Architecture);
}