using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rangedEnemy : MonoBehaviour
{
    public float distBetween;
    public float gunRange;
    public float p1dist;
    public float p2dist;
    public float enemySpeed;

    public Vector3 target;

    public GameObject player1;
    public GameObject player2;
    public eBulletSpawner gunSpawn;

    // Start is called before the first frame update
    void Start()
    {
        player1 = GameObject.FindGameObjectWithTag("Player 1");
        player2 = GameObject.FindGameObjectWithTag("Player 2");
        gunSpawn = GetComponentInChildren<eBulletSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        p1dist = Vector3.Distance(gameObject.transform.position, player1.transform.position);
        p2dist = Vector3.Distance(gameObject.transform.position, player2.transform.position);

        if (p1dist < p2dist)
        {
            target = player1.transform.position;
        }
        else if (p2dist < p1dist)
        {
            target = player2.transform.position;
        }
        else if (p1dist == p2dist)
        {
            target = player1.transform.position;
        }

        transform.LookAt(target);
        //transform.position += transform.forward * enemySpeed * Time.deltaTime;

        distBetween = Vector3.Distance(gameObject.transform.position, target);

        if (distBetween <= gunRange)
        {
            gunSpawn.canFire = true;
            Debug.Log("Can Fire is True");
        }
        else if (distBetween > gunRange)
        {
            gunSpawn.canFire = false;
            Debug.Log("Can Fire is False");
        }
    }

    
    //IEnumerator enemyShoot()
    //{
    //    gunSpawn.GetComponent<>
    //}
    
}
