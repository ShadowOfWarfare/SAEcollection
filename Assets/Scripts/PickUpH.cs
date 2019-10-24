using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpH : MonoBehaviour
{
    // Start is called before the first frame update

    public float health = 30f;
    public bool picked = false;
    Spawner spawn;

    void OnTriggerEnter(Collider col)
    {
        //if the player health is less than 100, the player will be able to pick it up.
        if (col.gameObject.tag == "Player 1")
        {
            GameObject player = col.gameObject;
            if (player.GetComponent<playerStats>().health < 100)
            {
                player.GetComponent<Spawner>().picked = true;
                Debug.Log("picked up");
                player.GetComponent<playerStats>().health += 30f;
                Destroy(gameObject);
                picked = true;
            }


            else
            {
                Debug.Log("health is full");
            }

            
        }
        
    }
}
