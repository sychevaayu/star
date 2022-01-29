using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snow : MonoBehaviour
{
    public Transform player;
    public float move_speed;
    public float rotation_speed;
    public Transform snow;
    void Update()
    {
        var look_dir = player.position - snow.position;
        //look_dir.y = 0;
        snow.rotation = Quaternion.Slerp(snow.rotation, Quaternion.LookRotation(look_dir), rotation_speed * Time.deltaTime);
        snow.position += snow.forward * move_speed * Time.deltaTime;
    }
}
