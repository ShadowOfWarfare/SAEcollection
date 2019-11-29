using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reviveCircle2 : MonoBehaviour
{
    public P2ReviveCircle revive;
    // Start is called before the first frame update
    void Start()
    {
        revive = GameObject.FindGameObjectWithTag("Respawn2").GetComponent<P2ReviveCircle>();
    }

    // Update is called once per frame
    void Update()
    {
        if (revive.playerDown == false)
        {
            Destroy(gameObject);
            revive.spawned = false;
        }
    }
}
