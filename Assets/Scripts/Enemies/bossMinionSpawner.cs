using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossMinionSpawner : MonoBehaviour
{
    public BossBulletDMG bb;
    public GameObject enemy;
    public bool firstSpawn;
    public bool secondSpawn;
    public bool thirdSpawn;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (bb.health <= 1500 && firstSpawn == false)
        {
            Instantiate(enemy, transform.position, transform.rotation);
            firstSpawn = true;
        }
        else if (bb.health <= 1000 && secondSpawn == false)
        {
            Instantiate(enemy, transform.position, transform.rotation);
            secondSpawn = true;
        }
        else if (bb.health <= 500 && thirdSpawn == false)
        {
            Instantiate(enemy, transform.position, transform.rotation);
            thirdSpawn = true;
        }
    }

}
