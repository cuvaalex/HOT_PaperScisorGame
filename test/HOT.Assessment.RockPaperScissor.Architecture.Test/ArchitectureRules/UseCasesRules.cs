namespace HOT.Assessment.RockPaperScissor.Architecture.Test.ArchitectureRules;

using ArchUnitNET.Fluent.Syntax.Elements.Types;
using Xunit;
using static ArchUnitNET.Fluent.ArchRuleDefinition;

public class UseCasesRules
{
    private static GivenTypesConjunctionWithDescription UseCases() =>
        Types()
            .That()
            .ResideInNamespace(Namespaces.UseCases, true)
            .As("Use Cases");

    [Fact]
    public void ShouldNotDependOnInfrastructure() =>
        UseCases()
            .Should()
            .NotDependOnAny(Namespaces.Infrastructure)
            .Check();

    [Fact]
    public void UseCaseClassesShouldResideInUseCases() =>
        Classes()
            .That()
            .HaveNameEndingWith("UseCase")
            .Should()
            .ResideInNamespace(Namespaces.UseCases, true)
            .Check();

    [Fact(Skip = "No Handlers used")]
    public void UseCaseClassesShouldImplementUseCaseInterface() =>
        Classes()
            .That()
            .HaveNameEndingWith("UseCase")
            .Should()
            .ImplementInterface("IRequestHandler", true)
            .Check();
}
