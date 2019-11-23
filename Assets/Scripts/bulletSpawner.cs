using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletSpawner : MonoBehaviour
{
    public GameObject bullet;
    public playerStats pStats;

    void Start()
    {
        pStats = GetComponentInParent<playerStats>();
    }

    // Update is called once per frame
    void Update()
    {

        if (pStats.curAmmo != 0)
        {
            if (Input.GetButtonDown("Fire3"))
            {
                Instantiate(bullet, transform.position, transform.rotation);
                pStats.curAmmo -= 1;
            }
            Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
            Debug.DrawRay(transform.position, forward, Color.green);
        }
    }
}
