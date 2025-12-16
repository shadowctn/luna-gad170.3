using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
      List<GameObject> SpawnedPlants = new List<GameObject>();
    [SerializeField] GameObject[] SpawnPoints;
    [SerializeField] GameObject[] plants;
    int SpawnPointsIndex = 0;


    void Start()
    {
        Spawn();
    }


    public void Spawn()
    {
        DestroyPlants(); 
        int spawnCount = Mathf.Min(3, SpawnPoints.Length);
        for (int i = 0; i < spawnCount; i++)
        {
            int randomPlant = Random.Range(0, plants.Length);
            GameObject prefab = plants[randomPlant];
            Vector3 position = SpawnPoints[i].transform.position;
            Quaternion rotation = Quaternion.identity;

            GameObject go = Instantiate(prefab, position, rotation);
            SpawnedPlants.Add(go);
        }
        SpawnPointsIndex = 0;
    
    }
    public void DestroyPlants()
    {
        for (int i = 0; i < SpawnedPlants.Count; i++)
        {
            if (SpawnedPlants[i] != null)
                Destroy(SpawnedPlants[i]);
        }
        SpawnedPlants.Clear();
        SpawnPointsIndex = 0;
    }
}
