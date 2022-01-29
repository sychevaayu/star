using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Key : MonoBehaviour
{
    public UnityEvent OnGetKey;
    private void OnTriggerEnter(Collider other)
    {
        DoSmt();
        OnGetKey.Invoke();
    }
    public void DoSmt()
    {

    }
   // public void GetKey() => OnGetKey.Invoke(true);

}
