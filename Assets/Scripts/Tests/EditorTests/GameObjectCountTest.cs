using NUnit.Framework;
using UnityEngine;

public class GameObjectCountTest
{

    [Test]
    public void SpawnAllObjects_SpawnsExpectedAmountOfObjects()
    {
        var gameObject = new GameObject();
        var _script = gameObject.AddComponent<InstantiateObjects>();
        _script.Start();

        Assert.That(_script.numberOfObjectsSpawned, Is.LessThan(1000));
    }
}
