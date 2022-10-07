using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{

    public GameObject[] myObjects;
    public int numberOfObjectsToSpawn = 100;
    public int numberOfObjectsSpawned = 0;


    void Start()
    {
        for(int i =0; i<numberOfObjectsToSpawn; i++)
        {
            if (SpawnObjects())
            {
                numberOfObjectsSpawned++;
            }
        }
    }

    public bool SpawnObjects()
    {
            int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));

            Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
            return true;
    }


}