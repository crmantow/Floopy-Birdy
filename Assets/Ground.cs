using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private Bird _bird;
    [SerializeField] private float _speed = 1;
    [SerializeField] private Transform _nextPos;

    private void Update()
    {
        if (_bird == null || (_bird != null && !_bird.IsDead))
        {
            transform.Translate(Vector3.left * _speed * Time.deltaTime, Space.World);
        }
    }

    public void SetNextGround(GameObject ground) => ground.transform.position = _nextPos.position;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (_bird != null && !_bird.IsDead)
        {
            _bird.Dead();
        }
    }
}
