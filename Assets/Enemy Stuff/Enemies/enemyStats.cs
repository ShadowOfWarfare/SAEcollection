using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyStats : MonoBehaviour
{
    public float maxHealth = 10f;
    public float curHealth;

    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
    }

    void OnCollisionEnter(Collision bullCol)
    {
        if (bullCol.transform.tag == "dpBullet")
        {
            curHealth -= 1;
        }
        else if (bullCol.transform.tag == "sgBullet")
        {
            curHealth -= 3;
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
