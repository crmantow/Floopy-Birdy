using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out IRespawnablePlatforms respawnable))
        {
            respawnable.Respawn(respawnable.transform);
        }
    }
}
