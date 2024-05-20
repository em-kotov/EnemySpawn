using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Target _target;
    [SerializeField] private float _speed;

    public void GenerateEnemy()
    {
        Enemy enemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity);
        enemy.SetParameters(_target, _speed);
    }
}
