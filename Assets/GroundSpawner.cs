using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    [SerializeField] private Ground _groundPrefab;

    private Ground _prevGround;

    private void SpawnGround()
    {
        if (_prevGround)
        {
            var newGround = Instantiate(_groundPrefab);
            _prevGround.SetNextGround(newGround.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.TryGetComponent<Ground>(out Ground ground))
        {
            _prevGround = ground;

            SpawnGround();
        }
    }
}
