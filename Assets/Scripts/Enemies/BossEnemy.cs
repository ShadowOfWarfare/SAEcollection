using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemy : MonoBehaviour
{
    public float maxHealth;
    public float curHealth;
    public float damage;
    public float stickDamage;
    public int attackTime;

    public playerStats pStats;

    public bool isTrigger;

    public BossBulletDMG bb;




   
    void Start()
    {
        curHealth = maxHealth;
        isTrigger = false;

        bb = GetComponentInChildren<BossBulletDMG>();
        
    }



    void OnTriggerEnter(Collider col)
    {
        pStats = col.GetComponent<playerStats>();

        if (col.gameObject.tag == "Player 1" || col.gameObject.tag == "Player 2")
        {
            isTrigger = true;
            if (pStats.health < 0)
            {
                pStats.health = 0;
            }
            else
            {
                Debug.Log("damage taken");
                pStats.health -= stickDamage;
            }

        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player 1" || col.gameObject.tag == "Player 2")
        {
            isTrigger = false;
        }
    }
   
    void Update()
    {
      
    }
}
