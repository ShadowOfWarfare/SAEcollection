using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossBulletDMG : MonoBehaviour
{
    
    public enemyStats eStats;
    public float health;
    public float maxHealth;
    public GameObject handL, handR;
    public float percentage;

    public event System.Action<float> updateHealth;


    void Start()
    {
        eStats = GetComponentInParent<enemyStats>();

    }

    void Update()
    {
        percentage = health / maxHealth;
        updateHealth(percentage);
    }

    private void OnCollisionEnter(Collision col)
    {


        if (col.transform.tag == "Bullet")
        {
            playerStats pStats = col.collider.gameObject.GetComponent<bullet>().pStats;
            if (health <= 0)
            {
                Destroy(gameObject);
                Destroy(handR);
                Destroy(handL);
                SceneManager.LoadScene("Menu");
            }
            else
            {
                health -= pStats.attack;
            }
        }
    }

    
}
