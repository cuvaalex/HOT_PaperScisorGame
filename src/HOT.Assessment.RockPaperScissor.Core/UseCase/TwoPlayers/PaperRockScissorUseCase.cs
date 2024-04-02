using HOT.Assessment.RockPaperScissor.Core.Domain.Game;
using HOT.Assessment.RockPaperScissor.Core.Domain.Hand;

namespace HOT.Assessment.RockPaperScissor.Core.UseCase.TwoPlayers;

public class PaperRockScissorUseCase(GamePaperRockScissor gamePaperRockScissor) : IPaperRockScissorUseCase
{
    
    private readonly Array _handActionValues = Enum.GetValues(typeof(HandAction));

    public TwoPlayerResponse Play(TwoPlayerRequest request)
    {
        string? message = gamePaperRockScissor.Play(request.Hand1, request.Hand2);

        return BuildTwoPlayerResponse(message);
    }

    public HandAction RandomHand()
    {
        var random = new Random();
        HandAction randomHand = (HandAction)_handActionValues
            .GetValue(random.Next((_handActionValues.Length)))!;

        return randomHand;
    }

    private TwoPlayerResponse BuildTwoPlayerResponse(string? result)
    {
        return new TwoPlayerResponse(gamePaperRockScissor.Player1, gamePaperRockScissor.Player2, result);
    }


}