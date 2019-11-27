using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStats : MonoBehaviour
{
    
    
    public float health;
    public float maxHealth;
    //public float percentage;
    public float attack;
    public float armour;
    public int curAmmo;
    public int maxAmmo;

    public int attacktime;

    public event System.Action<float> updateHealth;


    

    

    


    // Start is called before the first frame update
    void Start()
    {
     
       
    }

    // Update is called once per frame
    void Update()
    {
       if(health <= 0)
        {
            curAmmo = 0;
        }
        //percentage = health / maxHealth;
        //updateHealth(percentage);
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.transform.tag == "eBullet")
        {
            if (health < 0)
            {
                health = 0;
                
            }
            else
            {
                Debug.Log("damage taken");
                enemyStats eStats = col.collider.GetComponent<eBullet>().eStats;
                health -= eStats.damage;
            }
        }
    }

    


    
}
