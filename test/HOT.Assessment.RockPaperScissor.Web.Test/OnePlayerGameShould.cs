using Bunit;
using Moq;
using Xunit;
using HOT.Assessment.RockPaperScissor.Core.UseCase.TwoPlayers;
using HOT.Assessment.RockPaperScissor.Core.Domain.Hand;
using HOT.Assessment.RockPaperScissor.WebApp.Components;
using HOT.Assessment.RockPaperScissor.WebApp.Components.Pages;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;

public class OnePlayerGameShould
{
    private Mock<IPaperRockScissorUseCase> paperRockScissorUseCaseMock;

    public OnePlayerGameShould() 
    {
        paperRockScissorUseCaseMock = new Mock<IPaperRockScissorUseCase>();
        // Set up your mock behavior here...
    }

    [Fact]
    public void CheckSecondButton_Click_HandIcon1()
    {
        // Arrange
        using var ctx = new TestContext();

        // Register your mocked service
        ctx.Services.AddSingleton(paperRockScissorUseCaseMock.Object);

        // Act: render the component under test
        var cut = ctx.RenderComponent<OnePlayerGame>();

        // Get second button
        var buttons = cut.FindAll("button");
        var secondButton = buttons[1];

        // Trigger the action
        secondButton.Click();

        // Assert that _handIcon1 has changed after the click. Adjust according to your requirements.
        // Here a simplified assertion is provided as example.
        var expectedIcon = HandViewHelper.GetActionClass(HandAction.Paper); // use expected HandAction
        cut.Instance.HandIcon1.Should().Be(expectedIcon);
    }
}