using HOT.Assessment.RockPaperScissor.Core.Domain.Game;

namespace HOT.Assessment.RockPaperScissor.Core.UseCases;

public interface IPaperRockScissorUseCase
{
    TwoPlayerResponse Play(TwoPlayerRequest request);
    HandAction RandomHand();
    TwoPlayerResponse NewGame();
}