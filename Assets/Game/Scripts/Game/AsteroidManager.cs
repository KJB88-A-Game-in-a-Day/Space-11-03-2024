using GDLib.Comms;
using Space;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidManager : MonoBehaviour
{
    [Header("Core")]
    [SerializeField] GameObject asteroidPrefab;

    [Header("Content")]
    [SerializeField] int maxAsteroids = 4;
    List<GameObject> activeAsteroids = new();

    ObjectPool objPool;
    // Start is called before the first frame update
    void Start()
    {
        if (ServiceLocator.RequestService(ServiceLibrary.ObjectPool, out IService service))
            objPool = (ObjectPool)service;

        SpawnAsteroids(maxAsteroids);
    }

    private void SpawnAsteroids(int numToSpawn)
    {
        for (int i = 0; i < numToSpawn; i++)
            if (objPool.GetPooledObject(PoolLibrary.Asteroid, out GameObject go))
            {
                activeAsteroids.Add(go);
                go.transform.position = new Vector2(
                    Random.Range(GameManager.instance.MinBoundX, GameManager.instance.MaxBoundX),
                    4.5f);

                go.SetActive(true);
            }
    }
    //// Update is called once per frame
    //void Update()
    //{
    //    if (activeAsteroids.Count < maxAsteroids)
    //        SpawnAsteroids(3);

    //}
}
