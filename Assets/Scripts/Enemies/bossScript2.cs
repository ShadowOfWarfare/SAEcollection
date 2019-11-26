using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossScript2 : MonoBehaviour
{
    public float p1dist;
    public float p2dist;
    public float enemySpeed;

    public Vector3 target;

    public GameObject player1;
    public GameObject player2;

    // Start is called before the first frame update
    void Start()
    {
        //player1 = GameObject.FindGameObjectWithTag("Player 1");
        player2 = GameObject.FindGameObjectWithTag("Player 2");
    }

    // Update is called once per frame
    void Update()
    {
        target = player2.transform.position;
        transform.LookAt(target);
    }
}
