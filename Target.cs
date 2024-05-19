using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private float _speed;

    private int _currentWaypoint;

    private void Start()
    {
        _currentWaypoint = Random.Range(0, _waypoints.Length);
    }

    void Update()
    {
        if (transform.position == _waypoints[_currentWaypoint].position)
            SetNewWaypointIndex();

        Move();
        transform.LookAt(_waypoints[_currentWaypoint].position);
    }

    private void SetNewWaypointIndex()
    {
        _currentWaypoint = (_currentWaypoint + 1) % _waypoints.Length;
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position,
                                                 _waypoints[_currentWaypoint].position,
                                                 _speed * Time.deltaTime);
    }
}
