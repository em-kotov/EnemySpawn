using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float _repeatRate;
    [SerializeField] private SpawnPoint[] _spawnPoints;

    private void Start()
    {
        StartCoroutine(SpawnEnemies(_repeatRate));
    }

    private SpawnPoint GetRandomSpawnPoint()
    {
        return _spawnPoints[Random.Range(0, _spawnPoints.Length)];
    }

    private IEnumerator SpawnEnemies(float seconds)
    {
        var wait = new WaitForSeconds(seconds);

        while (enabled)
        {
            GetRandomSpawnPoint().GenerateEnemy();
            yield return wait;
        }
    }
}
