using System.Collections;
using Unity.Mathematics;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float _interval = 2f;
    [SerializeField] private float _holeSize = 1f;
    [SerializeField] private float _maxMinOffset = 1f;

    private IEnumerator Start()
    {
        while (true)
        {
            if (GameManager.IsGameOver)
            {
                yield return null;
            }

            SpawnPipe();

            yield return new WaitForSeconds(_interval);
        }
    }

    private void SpawnPipe()
    {
        var newPipeUp = ObjectPool.Instance.GetPooledObject();
        newPipeUp.transform.SetPositionAndRotation(
            transform.position += Vector3.up * (_holeSize / 2),
            Quaternion.Euler(0, 0, 180)
        );
        newPipeUp.SetActive(true);

        var newPipeDown = ObjectPool.Instance.GetPooledObject();
        newPipeDown.transform.SetPositionAndRotation(
            transform.position += Vector3.down * (_holeSize / 2),
            Quaternion.identity
        );
        newPipeDown.SetActive(true);

        //add smooth wave effect
        float y = _maxMinOffset * Mathf.Sin(Time.time);

        newPipeUp.transform.position += Vector3.up * y;
        newPipeDown.transform.position += Vector3.up * y;
    }
}
