public class Game
{
    public int StartingLives = 20;
    public int Score = 0;

    public void AddScore(int points)
    {
        Score += points;
        Console.WriteLine($"Score: {Score}");
    }
}