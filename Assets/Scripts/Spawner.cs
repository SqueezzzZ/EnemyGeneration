using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Transform[] _spawnPoints;

    private float _repeatRate = 2f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 0.0f, _repeatRate);
    }

    private void SpawnEnemy()
    {
        Enemy enemy = Instantiate(_enemyPrefab, GetRandomSpawnPoint(), Quaternion.identity);

        enemy.SetMovementDirection(GetRandomDirection());
    }

    private Vector3 GetRandomSpawnPoint()
    {
        int spawnPointNumber = Random.Range(0, _spawnPoints.Length);

        return _spawnPoints[spawnPointNumber].position;
    }

    private Vector3 GetRandomDirection()
    {
        Vector3 direction = Random.onUnitSphere;

        direction.y = 0f;

        return direction;
    }
}