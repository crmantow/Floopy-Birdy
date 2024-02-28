using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bird : MonoBehaviour
{
    [Header("Reference's")]
    [SerializeField] private Rigidbody2D _rigidbody2D;

    [Header("Design")]
    [SerializeField] private float _upForce = 100;
    [SerializeField] private bool _isDead;
    [SerializeField] private UnityEvent OnJump, OnDead;

    private void Update()
    {
        if (!_isDead && Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    public bool IsDead => _isDead;

    public void Dead()
    {
        if (_isDead) { return; }

        OnDead?.Invoke();

        _isDead = true;
    }

    private void Jump()
    {
        if (_rigidbody2D)
        {
            //stop the bird speed
            _rigidbody2D.velocity = Vector2.zero;

            //add force to make bird jump
            _rigidbody2D.AddForce(new Vector2(0, _upForce));

            OnJump?.Invoke();
        }
    }
}
