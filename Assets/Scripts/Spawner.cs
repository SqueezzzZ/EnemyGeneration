using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private SpawnPoint[] _spawnPoints;

    private float _repeatRate = 2f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 0.0f, _repeatRate);
    }

    private void SpawnEnemy()
    {
        SpawnPoint spawnPoint = GetRandomSpawnPoint();

        spawnPoint.CreateEnemy();
    }

    private SpawnPoint GetRandomSpawnPoint()
    {
        return _spawnPoints[Random.Range(0, _spawnPoints.Length)];
    }    
}