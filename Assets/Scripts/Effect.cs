using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
   
    private float Timer = 0.15f;
    private void StartEffect()
    {
        Timer -= Time.deltaTime;
        if (Timer<=0)
        {
            Destroy(gameObject);
            
        }
    }
    
}
