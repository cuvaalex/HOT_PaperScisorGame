using HOT.Assessment.RockPaperScissor.Core.Domain.Hand;
using HOT.Assessment.RockPaperScissor.WebApp.Components.Pages;

namespace HOT.Assessment.RockPaperScissor.Web.Test;

public class HandTest : TestContext
{
    [Theory]
    [InlineData(HandAction.Rock, "fa fa-hand-rock-o")]
    [InlineData(HandAction.Scissors, "fa fa-hand-scissors-o")]
    [InlineData(HandAction.Paper, "fa fa-hand-paper-o")]
    void HandButtonDisplayAction(HandAction handButtonAction, string expectedIcon)
    {
        //Arrange
        var cut = RenderComponent<OnePlayerGame>();
        var buttonElement = cut.Find("button");
        
        // Act
        buttonElement.Click();
        
        //Assert
        
    }
    
}