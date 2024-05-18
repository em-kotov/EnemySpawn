using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float _repeatRate;
    [SerializeField] private float _speed;
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Transform _target;

    private void Start()
    {
        StartCoroutine(SpawnEnemies(_repeatRate));
    }

    private void GenerateEnemy()
    {
        Enemy enemy = Instantiate(_enemyPrefab, GetRandomSpawnPosition());
        enemy.SetParameters(_target.position, _speed);
    }

    private Transform GetRandomSpawnPosition()
    {
        return _spawnPoints[Random.Range(0, _spawnPoints.Length)];
    }

    private IEnumerator SpawnEnemies(float seconds)
    {
        var wait = new WaitForSeconds(seconds);

        while (enabled)
        {
            GenerateEnemy();
            yield return wait;
        }
    }
}
