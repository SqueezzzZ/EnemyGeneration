using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform[] _routePoints;
    [SerializeField] private float _speed;

    private int _currentPointNumber = 0;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        if (transform.position == _routePoints[_currentPointNumber].position)
        {
            _currentPointNumber = (_currentPointNumber + 1) % _routePoints.Length;
        }

        transform.position = Vector3.MoveTowards(transform.position, _routePoints[_currentPointNumber].position, _speed * Time.deltaTime);
    }
}