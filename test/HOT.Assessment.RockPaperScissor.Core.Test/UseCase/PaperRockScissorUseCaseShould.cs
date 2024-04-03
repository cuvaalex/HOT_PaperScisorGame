using FluentAssertions;
using HOT.Assessment.RockPaperScissor.Core.Domain.Game;
using HOT.Assessment.RockPaperScissor.Core.Domain.Hand;
using HOT.Assessment.RockPaperScissor.Core.UseCases;

namespace HOT.Assessment.RockPaperScissor.Core.Test.UseCase;

public class PaperRockScissorUseCaseShould
{
    private PaperRockScissorUseCase? _useCase;

    [Theory]
    [InlineData(HandAction.Rock, HandAction.Scissors, "Rock crushes Scissors")]
    [InlineData(HandAction.Rock, HandAction.Rock, "Draw")]
    [InlineData(HandAction.Paper, HandAction.Paper, "Draw")]
    [InlineData(HandAction.Scissors, HandAction.Scissors, "Draw")]
    [InlineData(HandAction.Scissors, HandAction.Paper, "Scissors cuts Paper")]
    [InlineData(HandAction.Paper, HandAction.Rock, "Paper covers Rock")]
    [InlineData(HandAction.Scissors, HandAction.Rock, "Rock crushes Scissors")]
    [InlineData(HandAction.Paper, HandAction.Scissors, "Scissors cuts Paper")]
    [InlineData(HandAction.Rock, HandAction.Paper, "Paper covers Rock")]
    void ReturnExpectedResult(HandAction hand1, HandAction hand2, string expected)
    {
        _useCase = new PaperRockScissorUseCase(new GamePaperRockScissor());
        
        var request = new TwoPlayerRequest(hand1, hand2);
        var result = _useCase.Play(request);
        
        result.MessageResult.Should().Be(expected);
    }

    [Fact]
    void ReturnRandomHandAction()
    {
        _useCase = new PaperRockScissorUseCase(new GamePaperRockScissor());
        var result = _useCase.RandomHand();


        result.Should().BeDefined();
    }

    [Fact]
    void ReturnZeroScoreForBothPlayerWhenNewGame()
    {
        _useCase = new PaperRockScissorUseCase(new GamePaperRockScissor());
        var request = new TwoPlayerRequest(HandAction.Paper, HandAction.Rock);
        var response = _useCase.Play(request);
        response.Should().NotBeNull();
        response.Player1Score.ValueScore.Should().BeGreaterThan(0);
        response.Player2Score.ValueScore.Should().Be(0);

        response = _useCase.NewGame();
        

        response.Should().NotBeNull();
        response.Player1Score.ValueScore.Should().Be(0);
        response.Player2Score.ValueScore.Should().Be(0);
    }
}


