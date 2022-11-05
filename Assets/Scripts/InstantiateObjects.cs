using System.Collections;
using UnityEngine;

public class InstantiateObjects : MonoBehaviour
{
    public GameObject gameObjectToSpawn;
    public int totalNumberOfObjectsToSpawn;
    public int numberOfObjectsSpawned = 0;
    Vector3 randomSpawnPosition = new Vector3(0, 0, 0);


    public void Start()
    {
        randomSpawnPosition = new Vector3(Random.Range(-10, 11), 500, Random.Range(-10, 11));
        SpawnGameObjects(randomSpawnPosition);
    }

    IEnumerator SpawnGameObjects(Vector3 spawnPosition)
    {
        while (numberOfObjectsSpawned < totalNumberOfObjectsToSpawn)
        {
            yield return new WaitForSeconds(0.00001f);
            SpawnObject(spawnPosition);
        }
    }


    private void Update()
    {
        numberOfObjectsSpawned = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            numberOfObjectsSpawned--;
            Destroy(collision.gameObject);
        }
    }


    public void SpawnObject(Vector3 randomSpawnPosition)
    {
        if (numberOfObjectsSpawned < totalNumberOfObjectsToSpawn)
        {
            Instantiate(gameObjectToSpawn, randomSpawnPosition, Quaternion.identity);
            numberOfObjectsSpawned++;
        }
    }

}




