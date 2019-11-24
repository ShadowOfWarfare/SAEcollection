using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyStats : MonoBehaviour
{
    public float maxHealth;
    public float curHealth;
    public float damage;
    public float stickDamage;
    public int attackTime;

    public playerStats pStats;

    public bool isTrigger;
    

   

    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
        isTrigger = false;
        //pStats = GetComponent<playerStats>();
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
                playerStats pStats = bullCol.collider.GetComponent<bullet>().pStats;
                curHealth -= pStats.attack;
            }
        }
        
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
    /*IEnumerator melee()
{

    if (isTrigger == true && pStats.health > 0)
    {

        Debug.Log("damage taken");
        pStats.health -= stickDamage;

    }
    yield return new WaitForSeconds(attackTime);
}*/

    // Update is called once per frame
    void Update()
    {
        if (curHealth <= 0)
        {
            Destroy(gameObject);
        }
        //StartCoroutine(melee());
    }
}
