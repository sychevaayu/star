using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Door : MonoBehaviour
    {
        public bool HasKey;
        public void SetKey() => HasKey = true;
        public Animation doorAnim;
        public BoxCollider doorCollider;

        private bool isOpened;
        private bool isClosed;

        public 
        void Start()
        {
            isClosed = true;
           // doorAnim = transform.GetComponent<Animation>();
        }

        void Update()
        {
            if (HasKey)
            {
                if (isClosed)
                {
                    doorAnim.Play("Door_Open");
                    doorCollider.enabled = false;
                    isOpened = true;
                }
                else
                {
                    doorAnim.Play("Door_Close");
                    doorCollider.enabled = true;
                    isClosed = true;
                }
            }
            else
            {
                doorAnim.Play("Door_Close");
                doorCollider.enabled = true;
                isClosed = true;
            }
        }
    }
}