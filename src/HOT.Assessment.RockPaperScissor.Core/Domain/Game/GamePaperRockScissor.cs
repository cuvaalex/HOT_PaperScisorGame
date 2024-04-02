using HOT.Assessment.RockPaperScissor.Core.Domain.Hand;

namespace HOT.Assessment.RockPaperScissor.Core.Domain.Game;

public interface IGamePaperRockScissor
{
    Player Player1 { get; }
    Player Player2 { get; }
    string? Play(HandAction hand1, HandAction hand2);
}

public class GamePaperRockScissor : IGamePaperRockScissor
{
    private const string? RockCrushesScissors = "Rock crushes Scissors";
    private const string? ScissorsCutsPaper = "Scissors cuts Paper";
    private const string? PaperCoversRock = "Paper covers Rock";
    public Player Player1 { get; private set; } = new Player(1);
    public Player Player2 { get; private set; } = new Player(2);
    
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

    private string? Player2Win(string? message)
    {
        Player2 = Player2.IncreaseScore();
        return message;
    }

    private string? Player1Win(string? message)
    {
        Player1 = Player1.IncreaseScore();
        return message;
    }
}
