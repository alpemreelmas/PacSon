public interface ISpawnPoint
{
    int spawnPoints { get; set;  }

    List<Vector2> GetSpawnPoints();
}