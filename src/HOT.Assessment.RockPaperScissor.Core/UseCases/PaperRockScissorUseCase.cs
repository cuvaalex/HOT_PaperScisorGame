using HOT.Assessment.RockPaperScissor.Core.Domain.Game;

namespace HOT.Assessment.RockPaperScissor.Core.UseCases;

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

    public TwoPlayerResponse NewGame()
    {
        gamePaperRockScissor.ResetScore();
        return BuildTwoPlayerResponse(string.Empty);
    }

    private TwoPlayerResponse BuildTwoPlayerResponse(string? result)
    {
        return new TwoPlayerResponse(gamePaperRockScissor, result);
    }


}