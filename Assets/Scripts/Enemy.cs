using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 0.005f;

    private Transform _target;

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        var direction = (_target.position - transform.position).normalized;

        transform.Translate(direction * _moveSpeed);
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }
}