using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Target _target;
    [SerializeField] private float _speed;

    public void GenerateEnemy()
    {
        Enemy enemy = Instantiate(_enemy, transform.position, Quaternion.identity);
        enemy.SetParameters(_target, _speed);
    }
}
