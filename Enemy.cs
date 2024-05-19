using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Target _target;
    private float _speed;

    private void Update()
    {
        MoveTowardsDirection();
        transform.LookAt(_target.transform);
    }

    private void MoveTowardsDirection()
    {
        transform.position = Vector3.MoveTowards(transform.position,
                                                 _target.transform.position,
                                                 _speed * Time.deltaTime);
    }

    public void SetParameters(Target target, float speed)
    {
        if (speed > 0)
            _speed = speed;

        _target = target;
    }
}
