using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Transform CameraTransform;
    public CharacterStatus characterStatus;
    public Animator anim;

    public float Vertical;
    public float Horizontal;
    public float MoveAmount;

    public Vector3 rotationDirection;
    public Vector3 moveDirection;

    public void MoveUpdate()
    {
        Vertical = Input.GetAxis("Vertical");
        Horizontal = Input.GetAxis("Horizontal");
        MoveAmount = Mathf.Clamp01(Mathf.Abs(Vertical) + Mathf.Abs(Horizontal));

        anim.SetFloat("Vertical", MoveAmount, 0.15f, Time.deltaTime);

        Vector3 move = CameraTransform.forward * Vertical * characterStatus.SpeedForward * Time.deltaTime;
        move += CameraTransform.right * Horizontal * characterStatus.SpeedRight * Time.deltaTime;
        moveDirection = move;
        rotationDirection = CameraTransform.forward;
        transform.localPosition += moveDirection;

        RotationNormal();
    }

    public void RotationNormal()
    {
        if(!characterStatus.isAiming)
        {
            rotationDirection = moveDirection;
        }

        Vector3 targetDir = rotationDirection;
        targetDir.y = 0;

        if (targetDir == Vector3.zero)
            targetDir = transform.forward;

        Quaternion lookDir = Quaternion.LookRotation(targetDir);
        Quaternion targetRotation = Quaternion.Slerp(transform.rotation, lookDir, 1);
        transform.rotation = targetRotation;
    }
}
