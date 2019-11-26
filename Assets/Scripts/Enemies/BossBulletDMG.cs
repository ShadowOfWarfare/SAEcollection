using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBulletDMG : MonoBehaviour
{
    
    public enemyStats eStats;
    public float health;

    
    void Start()
    {
        eStats = GetComponentInParent<enemyStats>();

    }

    private void OnCollisionEnter(Collision col)
    {


        if (col.transform.tag == "Bullet")
        {
            playerStats pStats = col.collider.gameObject.GetComponent<bullet>().pStats;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                health -= pStats.attack;
            }
        }
    }
}
