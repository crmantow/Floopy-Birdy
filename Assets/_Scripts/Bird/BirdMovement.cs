using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    [Header("Design")]
    [SerializeField] private float _velocity = 1.5f;
    [SerializeField] private float _rotationSpeed = 12f;

    private Rigidbody2D _rb;
    private Bird _bird;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _bird = GetComponent<Bird>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Jump();
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, _rb.velocity.y * _rotationSpeed);
    }

    private void Jump()
    {
        _rb.velocity = Vector2.up * _velocity;
        _bird.InvokeOnJump();
    }
}
