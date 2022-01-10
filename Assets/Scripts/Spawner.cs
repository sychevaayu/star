using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Snowman;
    public float spawn_time = 3;
    public float t = 0;
    public int count = 5;

    void Update()
    {
        t = t + Time.deltaTime;
        if ((t >= spawn_time) && (count > 0))
        {
            Vector3 transformPosition = transform.position;
            Vector3 spawnPoint = new Vector3(transformPosition.x + 3, transformPosition.y-1, transformPosition.z);
            GameObject snowman = Instantiate(Snowman, spawnPoint, Quaternion.identity);
            Destroy(snowman, 1.5f);
            count--;
            t = 0;
        }
    }
}
