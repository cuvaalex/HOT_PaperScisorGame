using HOTPaperScisorRock.Core.Domain;
using HOTPaperScisorRock.Web.Components;

namespace HOTPaperScisorRock.Acceptance.Test;

public class HandTest : TestContext
{
    [Theory]
    [InlineData(HandAction.Rock, "fa fa-hand-rock-o")]
    [InlineData(HandAction.Scissors, "fa fa-hand-scissors-o")]
    [InlineData(HandAction.Paper, "fa fa-hand-paper-o")]
    void HandButtonDisplayAction(HandAction handButtonAction, string expectedIcon)
    {
        var cut = RenderComponent<Hand>(parameters => parameters
            .Add(p => p.HandAction, handButtonAction)
        );

        cut.Find("i").ClassName.MarkupMatches(expectedIcon);
    }
    
}