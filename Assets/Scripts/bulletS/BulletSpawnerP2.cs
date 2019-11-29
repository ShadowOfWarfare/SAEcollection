﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawnerP2 : MonoBehaviour
{
    public GameObject bullet;
    public playerStats pStats;

    void Start()
    {
        pStats = GameObject.FindGameObjectWithTag("Player 2").GetComponent<playerStats>();
    }

    // Update is called once per frame
    void Update()
    {

        if (pStats.curAmmo > 0 && pStats.health > 0)
        {
            if (Input.GetButtonDown("Fire3 P2"))
            {
                GameObject bulletObj = Instantiate(bullet, transform.position, transform.rotation);
                bulletObj.GetComponent<bullet>().pStats = pStats;
                pStats.curAmmo -= 1;
            }
            Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
            Debug.DrawRay(transform.position, forward, Color.green);
        }
    }
}