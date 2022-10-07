using NUnit.Framework;
using UnityEngine;

public class GameObjectCountTest
{
    private InstantiateObjects _script;

    [Test]
    public void game_object_is_spawned()
    {
        //GameObject testGo = new GameObject("BallObject");
        //var gameObject = new GameObject();
        //_script = gameObject.AddComponent<InstantiateObjects>();
        //_script.numberOfObjectsSpawned = 0;
        //_script.totalNumberOfObjectsToSpawn = 1000;
        //Assert.AreEqual(true, _script.SpawnObject(testGo, new Vector3(0, 0, 0)));
    }

    [Test]
    public void all_game_objects_are_spawned()
    {
        //GameObject testGo = new GameObject("BallObject");
        //var gameObject = new GameObject();
        //_script = gameObject.AddComponent<InstantiateObjects>();
        //_script.totalNumberOfObjectsToSpawn = 1000;
        //Assert.AreEqual(1000, _script.SpawnAllObjects(testGo, 1000));
    }
}
