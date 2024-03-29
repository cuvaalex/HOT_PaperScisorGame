using HOT.Assessment.RockPaperScissor.Core.Domain.Game;

namespace HOT.Assessment.RockPaperScissor.Core.UseCase.TwoPlayers;

public sealed record TwoPlayerResponse(Player Player1, Player Player2, string Result);