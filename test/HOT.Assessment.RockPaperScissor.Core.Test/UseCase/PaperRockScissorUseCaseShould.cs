using FluentAssertions;
using HOT.Assessment.RockPaperScissor.Core.Domain.Game;
using HOT.Assessment.RockPaperScissor.Core.Domain.Hand;
using HOT.Assessment.RockPaperScissor.Core.UseCase.TwoPlayers;

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
}


