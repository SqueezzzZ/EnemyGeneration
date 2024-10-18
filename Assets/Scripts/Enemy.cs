using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 0.005f;
    [SerializeField] private Vector3 _moveDirection = Vector3.zero;

    private void Update()
    {
        Move();
    }

    public void SetMovementDirection(Vector3 direction)
    {
        _moveDirection = direction;
    }

    public void Move()
    {
        transform.Translate(_moveDirection * _moveSpeed);
    }
}