public class Ui
{
    public float ScoreMultiplier = 21f;

    public void DisplayScore(int score)
    {
        Console.WriteLine($"Score: {score * ScoreMultiplier}");
    }
}