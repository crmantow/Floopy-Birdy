using UnityEngine;

public class Ground : MonoBehaviour, ICollidable, IRespawnablePlatforms
{
    [SerializeField] private Transform _posRef;

    private GroundSpawner _groundSpawner;

    private void Start() =>
        _groundSpawner = FindObjectOfType<GroundSpawner>();

    public void Respawn(Transform transform) =>
        _groundSpawner.SetLastGround(transform);
}
