using HOT.Assessment.RockPaperScissor.Core.Domain.Hand;

namespace HOT.Assessment.RockPaperScissor.Core.UseCase.TwoPlayers;

public record TwoPlayerRequest(HandAction Hand1, HandAction Hand2);
