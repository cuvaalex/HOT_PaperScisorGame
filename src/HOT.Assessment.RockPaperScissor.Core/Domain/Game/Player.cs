namespace HOT.Assessment.RockPaperScissor.Core.Domain.Game;

public readonly record struct Player
{

    public int PlayerId { get; init; }
    public Score Score { get; init; } = new();
    public Hand? Hand { get; init; } = null;

    public Player(int playerId, Score score, Hand? hand)
    {
        PlayerId = playerId;
        Score = score;
        Hand = hand;
    }

    public Player(int playerId)
    {
        PlayerId = playerId;
    }

    public Player IncreaseScore()
    {
        return new Player(PlayerId, Score.IncreaseScore(), Hand);
    }
}
