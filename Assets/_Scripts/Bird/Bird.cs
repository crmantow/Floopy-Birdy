using UnityEngine;
using UnityEngine.Events;

public class Bird : MonoBehaviour
{
    [SerializeField] private UnityEvent OnJump, OnDead;

    public void InvokeOnJump() => OnJump?.Invoke();

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.TryGetComponent(out ICollidable _))
        {
            GameManager.IsGameOver = true;

            OnDead?.Invoke();
        }
    }
}
