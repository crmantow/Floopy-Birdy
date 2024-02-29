using UnityEngine;

public class Pipe : MonoBehaviour, ICollidable, IRespawnablePlatforms
{
    public void Respawn(Transform transform)
    {
        transform.gameObject.SetActive(false);
    }
}
