using Assets.Extension;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    public GameObject Ming;

    public GameObject Effects;

    private bool canDestroy;

    /* private void Start()
     {
         Ming =
     } */

    private void Update()
    {
        if (canDestroy)
        {
            Destroy(Ming);
        }
    }

    private void OnTriggerEnter(Collider Min)
    {
        if (Min.IsNull())
        {
            return;
        }

        Effects.active = true;
        Ming.GetComponent<Animator>().SetBool("On", true);
        canDestroy = true;
        Destroy(Min.gameObject);

    }
}
