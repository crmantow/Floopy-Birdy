using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 1;

    private void Update()
    {
        if (!GameManager.IsGameOver)
            transform.Translate(_speed * Time.deltaTime * Vector3.left, Space.World);
    }
}
