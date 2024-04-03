namespace HOT.Assessment.RockPaperScissor.Core.Domain.Game;

public record Score(uint Value = 0)
{
    public Score IncreaseScore()
    {
        return new Score(Value + 1);
    }
    
}