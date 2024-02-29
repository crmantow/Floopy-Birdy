using UnityEngine;

public interface IRespawnablePlatforms
{
    Transform transform { get; }
    void Respawn(Transform transform);
}
