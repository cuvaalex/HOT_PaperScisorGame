using HOTPaperScisorRock.Core.Domain;
using FluentAssertions;
using Xunit;
using static HOTPaperScisorRock.Core.Domain.ScissorsRockPaperUseCase;


namespace HOTPaperScisorRock.Core.Test;

public class ScissorsRockPaperUseCaseShould
{
    private ScissorsRockPaperUseCase _useCase;

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
        _useCase = new ScissorsRockPaperUseCase();
        var request = new HandActionRequest(hand1, hand2);
        var result = _useCase.Play(request);
        result.Result.Should().Be(expected);
    }
}


