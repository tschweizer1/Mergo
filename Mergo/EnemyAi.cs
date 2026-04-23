public class EnemyAi
{
    public float DetectionRadius = 20000f;
    public float PatrolSpeed = 0f;

    public void Patrol()
    {
        Console.WriteLine($"Patrolling at speed {PatrolSpeed}");
    }
}