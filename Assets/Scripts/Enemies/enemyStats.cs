using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyStats : MonoBehaviour
{
    public float maxHealth = 10f;
    public float curHealth;
    public float damage;

    public playerStats pStats;

    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
        pStats = GetComponent<playerStats>();
    }

    void OnCollisionEnter(Collision bullCol)
    {
        if (bullCol.transform.tag == "Bullet")
        {
            if (curHealth <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                curHealth -= pStats.attack;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (curHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
