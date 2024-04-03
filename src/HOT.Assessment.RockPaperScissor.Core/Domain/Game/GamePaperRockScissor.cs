namespace HOT.Assessment.RockPaperScissor.Core.Domain.Game;

public class GamePaperRockScissor
{
    private const string RockCrushesScissors = "Rock crushes Scissors";
    private const string ScissorsCutsPaper = "Scissors cuts Paper";
    private const string PaperCoversRock = "Paper covers Rock";

    public Score Player1Score { get; private set; } = new Score();
    public Score Player2Score { get; private set; } = new Score();

    public string? Play(HandAction hand1, HandAction hand2)
    {
        return hand1 switch
        {
            HandAction.Rock when hand2 == HandAction.Scissors => Player1Win(RockCrushesScissors),
            HandAction.Scissors when hand2 == HandAction.Paper => Player1Win(ScissorsCutsPaper),
            HandAction.Paper when hand2 == HandAction.Rock => Player1Win(PaperCoversRock),
            HandAction.Scissors when hand2 == HandAction.Rock => Player2Win(RockCrushesScissors),
            HandAction.Paper when hand2 == HandAction.Scissors => Player2Win(ScissorsCutsPaper),
            HandAction.Rock when hand2 == HandAction.Paper => Player2Win(PaperCoversRock),
            _ => "Draw"
        };
    }
    
    public void ResetScore()
    {
        Player1Score = new Score();
        Player2Score = new Score();
    }

    private string? Player2Win(string? message)
    {
        Player2Score = Player2Score.IncreaseScore();
        return message;
    }

    private string? Player1Win(string? message)
    {
        Player1Score = Player1Score.IncreaseScore();
        return message;
    }
}