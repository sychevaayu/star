using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Snowman;
    public float spawn_time = 3;
    public float t = 0;
    public int count = 5;
    public List<Vector3> spawnPoints;
    public List<GameObject> Snowmen;

    void Update()
    {
        t = t + Time.deltaTime;
        if ((t >= spawn_time) && (count > 0))
        {
            foreach (var spawnPoint in spawnPoints)
            {
                Snowmen.Add(Instantiate(Snowman, spawnPoint, Quaternion.identity));
            }

            count--;
            t = 0;
        }
    }
}
