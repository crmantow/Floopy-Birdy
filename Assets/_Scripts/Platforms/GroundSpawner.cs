using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    [SerializeField] private Vector3 _offset = new(3.36f, 0, 0);

    private Transform _lastGround;

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.TryGetComponent<Ground>(out Ground ground))
            _lastGround.position = ground.transform.position + _offset;
    }

    public void SetLastGround(Transform lastGround) =>
        _lastGround = lastGround;
}
