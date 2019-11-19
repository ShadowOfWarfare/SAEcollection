using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyStats : MonoBehaviour
{
    public float maxHealth = 10f;
    public float curHealth;
    public float damage;

    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
    }

    void OnCollisionEnter(Collision bullCol)
    {
        if (bullCol.transform.tag == "Bullet")
        {
            Destroy(gameObject);
        }
        else if (bullCol.transform.tag == "Bullet")
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
