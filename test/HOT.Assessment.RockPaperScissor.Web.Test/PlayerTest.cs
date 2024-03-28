using HOT.Assessment.RockPaperScissor.Core.Domain.Hand;
using HOT.Assessment.RockPaperScissor.Web.Components;

namespace HOT.Assessment.RockPaperScissor.Web.Test;

public class PlayerTest : TestContext
{
    [Fact]
    void PlayerStartsWithZeroScore()
    {
        var playerNumber = 1;
        var playerScore = 0;

        var cut = RenderComponent<Player>(parameters => parameters
            .Add(p => p.PlayerNumber, playerNumber)
            .Add(p => p.PlayerScore, playerScore)
        );
        
        cut.MarkupMatches(@"<div class=""player"">
                                              <div class=""score"">Player 1: 0</div>
            <div class=""action""><i class=""fa fa-hand-rock-o""></i></div>
            </div>");
    }
    
    [Theory]
    [InlineData(HandAction.Rock, "fa fa-hand-rock-o")]
    [InlineData(HandAction.Scissors, "fa fa-hand-scissors-o")]
    [InlineData(HandAction.Paper, "fa fa-hand-paper-o")]
    void PlayerDisplayAction(HandAction handAction, string expectedIcon)
    {
        var playerNumber = 1;
        var playerScore = 0;

        var cut = RenderComponent<Player>(parameters => parameters
            .Add(p => p.PlayerNumber, playerNumber)
            .Add(p => p.PlayerScore, playerScore)
            .Add(p => p.PlayerAction, handAction)
        );

        cut.Find("i").ClassName.MarkupMatches(expectedIcon);
    }
}