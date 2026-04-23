public class Ui
{
    public float ScoreMultiplier = 2f;

    public void DisplayScore(int score)
    {
        Console.WriteLine($"Score: {score * ScoreMultiplier}");
    }
}