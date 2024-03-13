using UnityEngine;
using GDLib.Comms;
using System.Collections.Generic;

public class ObjectPool : MonoBehaviour, IService
{
    [SerializeField] List<Pool> pools = new();
    private void Awake()
        => ServiceLocator.AddService(ServiceLibrary.ObjectPool, this);

    private void Start()
    {
        foreach (var pool in pools) 
            pool.InitializePool();
    }

    public bool GetPooledObject(string poolName, out GameObject pooledObject)
    {
        poolName = poolName.ToLower();
        pooledObject = null;

        foreach (Pool pool in pools)
        {
            if (pool.PoolName() != poolName) continue;
            if (pool.GetPooledObject(out pooledObject)) return true;
        }

        return false;
    }

    public void ReturnPooledObject(string poolName, GameObject returningObj)
    {
        foreach (Pool pool in pools)
        {
            if (pool.PoolName() != poolName) continue;
            
            pool.AddObjectToPool(returningObj);
            break;
        }
    }
}