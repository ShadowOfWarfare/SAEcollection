using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyMove2 : MonoBehaviour
{
    public float p1dist;
    public float p2dist;
    public float enemySpeed;

    public Vector3 targetDest;
    public Vector3 target;

    private NavMeshAgent agent;

    public GameObject player1;
    public GameObject player2;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player1 = GameObject.FindGameObjectWithTag("Player 1");
        player2 = GameObject.FindGameObjectWithTag("Player 2");
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

        agent.destination = target;
    }
}
