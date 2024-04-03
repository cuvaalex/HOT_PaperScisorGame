using HOT.Assessment.RockPaperScissor.Core.Domain.Game;

namespace HOT.Assessment.RockPaperScissor.Core.UseCases;

public sealed record TwoPlayerResponse(Score Player1Score, Score Player2Score, string? MessageResult)
{
    public TwoPlayerResponse(GamePaperRockScissor gamePaperRockScissor, string? message) : this(
        gamePaperRockScissor.Player1Score, gamePaperRockScissor.Player2Score, message)
    {
        
    }
}