using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 _direction;
    private float _speed;

    private void Update()
    {
        MoveTowardsDirection();
        transform.LookAt(_direction);
    }

    private void MoveTowardsDirection()
    {
        transform.position = Vector3.MoveTowards(transform.position, _direction, _speed * Time.deltaTime);
    }

    public void SetParameters(Vector3 direction, float speed)
    {
        if (speed > 0)
            _speed = speed;

        _direction = direction;
    }
}
