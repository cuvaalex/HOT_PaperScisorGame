using HOT.Assessment.RockPaperScissor.Core.Domain.Game;

namespace HOT.Assessment.RockPaperScissor.Core.UseCase.TwoPlayers;

public class TwoPlayersUseCase(GamePaperRockScissor gamePaperRockScissor)
{
    public TwoPlayerResponse Play(TwoPlayerRequest request)
    {
        String message = gamePaperRockScissor.Play(request.Hand1, request.Hand2);

        return BuildTwoPlayerResponse(message);
    }

    private TwoPlayerResponse BuildTwoPlayerResponse(string result)
    {
        return new TwoPlayerResponse(gamePaperRockScissor.Player1, gamePaperRockScissor.Player2, result);
    }

}