﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    //code done by Jesse
    public float bulletSpeed;
    public float despawnTime;
    public playerStats pStats;

    void Start()
    {
         
    }
    // Update is called once per frame
    void Update()
    {
        Rigidbody bulletRB = this.GetComponent<Rigidbody>();
        bulletRB.velocity = transform.forward * bulletSpeed;
    }

    private void OnCollisionEnter(Collision ballCol)
    {
        if (ballCol.other.tag == "Wall" || ballCol.other.tag == "Mutant" || ballCol.other.tag == "Player 1" || ballCol.other.tag == "Player 2")
        {
            Destroy(gameObject);
        }
    }
}
