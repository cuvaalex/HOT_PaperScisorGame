namespace HOTPaperScisorRock.Core.Domain;

public class ScissorsRockPaperUseCase
{
    public const string RockCrushesScissors = "Rock crushes Scissors";
    public const string ScissorsCutsPaper = "Scissors cuts Paper";
    public const string PaperCoversRock = "Paper covers Rock";

    public HandActionResponse Play(HandActionRequest request)
    {
        var response = request.Hand1 switch
        {
            HandAction.Rock when request.Hand2 == HandAction.Scissors => GetHandActionResponse(1, 0, RockCrushesScissors),
            HandAction.Scissors when request.Hand2 == HandAction.Paper => GetHandActionResponse(1,0, ScissorsCutsPaper),
            HandAction.Paper when request.Hand2 == HandAction.Rock => GetHandActionResponse(1, 0, PaperCoversRock),
            HandAction.Scissors when request.Hand2 == HandAction.Rock => GetHandActionResponse(0,1, RockCrushesScissors),
            HandAction.Paper when request.Hand2 == HandAction.Scissors => GetHandActionResponse(0,1,ScissorsCutsPaper),
            HandAction.Rock when request.Hand2 == HandAction.Paper => GetHandActionResponse(0,1,PaperCoversRock),
            _ => GetHandActionResponse(0, 0,"Draw")
        };
        
        return response;
    }

    private static HandActionResponse GetHandActionResponse(int player1Score, int player2Score, string result)
    {
        return new HandActionResponse(GetPlayer(1, player1Score), GetPlayer(2, player2Score), result);
    }

    private static PlayerScore GetPlayer(int playerId, int score)
    {
        return new PlayerScore(playerId, score);
    }

    public sealed record HandActionResponse(PlayerScore Player1, PlayerScore Player2, string Result);

    public record HandActionRequest(HandAction Hand1, HandAction Hand2);
    
    public sealed record PlayerScore(int PlayerId, int Score = 0);
}