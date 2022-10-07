using System.Collections;
using UnityEngine;

public class InstantiateObjects : MonoBehaviour
{
    public GameObject objectsSpawn;
    public int totalNumberOfObjectsToSpawn;
    public int numberOfObjectsSpawned = 0;
    Vector3 randomSpawnPosition = new Vector3(0, 0, 0);


    IEnumerator Start()
    {
        while(numberOfObjectsSpawned < totalNumberOfObjectsToSpawn)
        {
            randomSpawnPosition = new Vector3(Random.Range(-10, 11), 500, Random.Range(-10, 11));
            yield return new WaitForSeconds(0.00001f);
            SpawnObject(randomSpawnPosition);
        }
    }


    private void Update()
    {
        numberOfObjectsSpawned = GameObject.FindGameObjectsWithTag("Enemy").Length;
        Debug.Log(numberOfObjectsSpawned);
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
            Instantiate(objectsSpawn, randomSpawnPosition, Quaternion.identity);
            numberOfObjectsSpawned++;
        }
    }

}




