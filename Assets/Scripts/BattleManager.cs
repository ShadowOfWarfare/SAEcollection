using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleManager : MonoBehaviour
{
    public playerStats p1stats;
    public playerStats p2stats;
    // Start is called before the first frame update
    void Start()
    {
        p1stats = GameObject.FindGameObjectWithTag("Player 1").GetComponent<playerStats>();
        p2stats = GameObject.FindGameObjectWithTag("Player 2").GetComponent<playerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (p1stats.health <= 0 && p2stats.health <= 0)
        {
            SceneManager.LoadScene("Menu");
        }
    }

    //Player takes damage from enemy attacks
    //player health decreases
    //player attacks
    //player ammo decreases if its a picked up gun

    //enemy takes damage from player atatcks
    //enemy health decreases
    //enemy attacks

    //wave counter
    //despawn current wave
    //spawn next wave after a few seconds
    //increase wave counter
    //check wave count to trigger boss level
    //transition to boss level
}
