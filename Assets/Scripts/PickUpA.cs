using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpA : MonoBehaviour
{
    public GameObject weapon;
    public GameObject ammo;

    void OnTriggerEnter(Collider col)
    {

        //if the player has less ammo, the player will be able to pick it up.
        if (col.gameObject.tag == "Player 1" || col.gameObject.tag == "Player 2")
        {

        }
    }
            
}
