using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject _objectToPool;
    [SerializeField] private int _amountToPool;

    public static ObjectPool Instance;
    public List<GameObject> pooledObjects = new();

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        CreatePoolObject();
    }

    private void CreatePoolObject()
    {
        for (int i = 0; i < _amountToPool; i++)
        {
            var poolObject = Instantiate(_objectToPool);
            poolObject.SetActive(false);

            pooledObjects.Add(poolObject);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < _amountToPool; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }

        return null;
    }
}
