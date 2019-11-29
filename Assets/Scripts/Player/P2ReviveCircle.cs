using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2ReviveCircle : MonoBehaviour
{
    public GameObject circle;
    public playerStats p2Stats;
    public bool playerDown;
    public bool spawned;

    // Start is called before the first frame update
    void Start()
    {
        p2Stats = GameObject.FindGameObjectWithTag("Player 2").GetComponent<playerStats>();
    }

    // Update is called once per frame
    void Update()
    {

        if (p2Stats.health <= 0 && spawned == false)
        {
            playerDown = true;
            Instantiate(circle, transform.position, transform.rotation);
            spawned = true;
        }
        if (p2Stats.health > 0 && playerDown == true)
        {
            //Destroy(gameObject);
            playerDown = false;
        }

    }
}
