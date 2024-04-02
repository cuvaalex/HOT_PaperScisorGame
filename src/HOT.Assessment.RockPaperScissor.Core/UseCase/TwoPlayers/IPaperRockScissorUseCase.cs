using HOT.Assessment.RockPaperScissor.Core.Domain.Hand;

namespace HOT.Assessment.RockPaperScissor.Core.UseCase.TwoPlayers;

public interface IPaperRockScissorUseCase
{
    TwoPlayerResponse Play(TwoPlayerRequest request);
    HandAction RandomHand();
}