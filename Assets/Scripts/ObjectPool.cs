    using System.Collections.Generic;
    using UnityEngine;

    public class ObjectPool : MonoBehaviour
    {
        public List<GameObject> pooledObjects;
        public GameObject objectToPool;
        public int amountToPool;
        public static ObjectPool SharedInstance;

        Vector3 randomSpawnPosition = new Vector3(0, 0, 0);

        void Awake()
        {
            SharedInstance = this;
        }

        void Start()
        {
            pooledObjects = new List<GameObject>();
            for (int i = 0; i < amountToPool; i++)
            {
                GameObject initialGameObjectToPool = (GameObject)Instantiate(objectToPool);
                initialGameObjectToPool.SetActive(false);
                pooledObjects.Add(initialGameObjectToPool);
            }
        }


        private void Update()
        {
            randomSpawnPosition = new Vector3(Random.Range(-10, 11), 50, Random.Range(-10, 11));
            SpawnObject(randomSpawnPosition);
        }

        private void OnCollisionEnter(Collision collision)
        {
                if (gameObject.tag == "Enemy")
                {
                    gameObject.SetActive(false);
                }

        }

        public void SpawnObject(Vector3 randomSpawnPosition)
        {
            GameObject exsistingGameObjectFromPool = ObjectPool.SharedInstance.GetPooledObject("Enemy");
            if (exsistingGameObjectFromPool != null)
            {
                exsistingGameObjectFromPool.transform.position = randomSpawnPosition;
                exsistingGameObjectFromPool.SetActive(true);
            }
        }



        public GameObject GetPooledObject(string tag)
        {
            for (int i = 0; i < pooledObjects.Count; i++)
            {
                if (pooledObjects[i] != null && !pooledObjects[i].activeInHierarchy && pooledObjects[i].tag == tag)
                {
                    return pooledObjects[i];
                }
            }
            return null;
        }
    }