using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDmg : MonoBehaviour
{
    public playerStats pStats;
    public enemyStats eStats;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        playerStats pStats = col.collider.GetComponent<bullet>().pStats;
        enemyStats eStats = col.collider.GetComponent<enemyStats>();
        if (col.transform.tag == "Bullet")
        {
            if(eStats.curHealth <= 0)
            {
                Destroy(eStats.gameObject);
            }
            else
            {
                eStats.curHealth -= pStats.attack;
            }
        }
    }
}
