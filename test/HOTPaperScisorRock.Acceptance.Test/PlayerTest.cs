using HOTPaperScisorRock.Web.Components;

namespace HOTPaperScisorRock.Acceptance.Test;

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
    [InlineData(Player.EnumPlayerAction.Rock, "fa fa-hand-rock-o")]
    [InlineData(Player.EnumPlayerAction.Scissors, "fa fa-hand-scissors-o")]
    [InlineData(Player.EnumPlayerAction.Paper, "fa fa-hand-paper-o")]
    void PlayerDisplayAction(Player.EnumPlayerAction playerAction, string expectedIcon)
    {
        var playerNumber = 1;
        var playerScore = 0;

        var cut = RenderComponent<Player>(parameters => parameters
            .Add(p => p.PlayerNumber, playerNumber)
            .Add(p => p.PlayerScore, playerScore)
            .Add(p => p.PlayerAction, playerAction)
        );

        cut.Find("i").ClassName.MarkupMatches(expectedIcon);
    }
}