using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInventory : MonoBehaviour
{
    //public Animation anim;
    //public Transform targetLook;
    //public GameObject mCamera;
    //public Transform rHand;

    //public List<Item> item = new List<Item>();

    //public WeaponProperties firstWeapon;
    //public WeaponProperties secondWeapon;

    //public CharacterIK characterIK;
    //public CharacterInput characterInput;

    //public GameObject objWeapon;
    //Weapon activeWeapon;

    //public void InventoryUpdate()
    //{
    //    Ray ray = new Ray(mCamera.transform.position, mCamera.transform.forward * 5);
    //    RaycastHit hit;
    //    if (Physics.Raycast(ray, out hit))
    //    {
    //        if (Input.GetKeyDown(KeyCode.E))
    //        {
    //            if (hit.collider.GetComponent<Item>().typeItem == "Weapon")
    //            {
    //                Instantiate(firstWeapon.itemPrefab, hit.collider.transform.position, hit.collider.transform.rotation);
    //                DestroyWeapon();
    //                firstWeapon = hit.collider.GetComponent<Item>().weaponPropertiesItem;
    //                characterInput.SelWeapon = 2;
    //                anim.SetTrigger("Select");
    //                Destroy(hit.collider.gameObject);
    //            }
    //            else if(hit.collider.GetComponent<Item>().typeItem == "Other")
    //            {
    //                item.Add(hit.collider.GetComponent<Item>());
    //                Destroy(hit.transform.gameObject);
    //            }
    //        }
    //    }
    //}

}
