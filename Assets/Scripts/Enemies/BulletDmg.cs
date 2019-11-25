using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDmg : MonoBehaviour
{
    
    public enemyStats eStats;
    
    // Start is called before the first frame update
    void Start()
    {
        eStats = GetComponentInParent<enemyStats>();
        
    }

    private void OnCollisionEnter(Collision col)
    {

        
        if (col.transform.tag == "Bullet")
        {
            playerStats pStats = col.collider.gameObject.GetComponent<bullet>().pStats;
            if (eStats.curHealth <= 0)
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
