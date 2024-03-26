using HOTPaperScisorRock.Web.Components;
using HOTPaperScisorRock.Web.Components.Pages;
using FluentAssertions;
using HOTPaperScisorRock.Core.Domain;

namespace HOTPaperScisorRock.Acceptance.Test;

public class HomeTest : TestContext
{
    [Fact]
    void HomePageShouldContainTitle()
    {
        var cut = RenderComponent<Home>();
        cut.Find("h1").MarkupMatches(@"<h1>Welcome to HOT Paper Scissor Rock</h1>");
    }
    
    [Fact]
    void HomePageShouldContainResult()
    {
        var cut = RenderComponent<Home>();
        cut.Find("h2").Should().NotBeNull();
    }
    
    [Fact]
    void HomePageShouldContainPlayer1AndPlayer2EmptyHandAtStart()
    {
        var cut = RenderComponent<Home>();

        var players = cut.FindComponents<Player>();

        players.Should().SatisfyRespectively(
            first =>
            {
                first.Instance.PlayerNumber.Should().Be(1);
                first.Instance.PlayerScore.Should().Be(0);
                first.Instance.HandActionPlayer.Should().Be(HandAction.Paper);
            },
            second =>
            {
                second.Instance.PlayerNumber.Should().Be(2);
                second.Instance.PlayerScore.Should().Be(0);
                second.Instance.HandActionPlayer.Should().Be(HandAction.Paper);
            }
            );
    }
    
    
    [Fact]
    void HomePageShouldContainHandButtons()
    {
        var cut = RenderComponent<Home>();
        
        var buttons = cut.FindComponents<HandButton>();
        
        buttons.Should().SatisfyRespectively(
            first =>
            {
                first.Instance.HandActionButton.Should().Be(HandAction.Rock);
            },
            second =>
            {
                second.Instance.HandActionButton.Should().Be(HandAction.Scissors);
            },
            third =>
            {
                third.Instance.HandActionButton.Should().Be(HandAction.Paper);
            }
            );
    }
}