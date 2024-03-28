namespace HOT.Assessment.RockPaperScissor.Core.Domain;

public sealed record HandActionResponse(PlayerScore Player1, PlayerScore Player2, string Result);