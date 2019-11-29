using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1ReviveCircle : MonoBehaviour
{
    public GameObject circle;
    public playerStats p1Stats;
    public bool playerDown;
    public bool spawned;
    
    // Start is called before the first frame update
    void Start()
    {
        p1Stats = GameObject.FindGameObjectWithTag("Player 1").GetComponent<playerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (p1Stats.health <= 0 && spawned == false)
        {
            playerDown = true;
            Instantiate(circle, transform.position, transform.rotation);
            spawned = true;
        }
        if (p1Stats.health > 0 && playerDown == true)
        {
            //Destroy(gameObject);
            playerDown = false;
        }

    }
}
