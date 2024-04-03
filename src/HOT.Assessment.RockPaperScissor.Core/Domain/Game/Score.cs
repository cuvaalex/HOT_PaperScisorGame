namespace HOT.Assessment.RockPaperScissor.Core.Domain.Game;

public record Score(uint ValueScore = 0)
{
    public Score IncreaseScore()
    {
        return new Score(ValueScore + 1);
    }
    
}