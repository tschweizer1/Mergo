public class EnemyAi
{
    public float DetectionRadius = 0.005f;
    public float PatrolSpeed = 9999f;

    public void Patrol()
    {
        Console.WriteLine($"Patrolling at speed {PatrolSpeed}");
    }
}