using HOT.Assessment.RockPaperScissor.Core.Domain.Game;

namespace HOT.Assessment.RockPaperScissor.Core.UseCases;

public record TwoPlayerRequest(HandAction Hand1, HandAction Hand2);
