using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public CharacterMovement CharacterMovement;
    public void FixedUpdate()
    {
        CharacterMovement.MoveUpdate();
    }
}
