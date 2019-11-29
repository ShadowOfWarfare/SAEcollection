using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reviveCircleCode : MonoBehaviour
{
    public P1ReviveCircle revive;
    // Start is called before the first frame update
    void Start()
    {
        revive = GameObject.FindGameObjectWithTag("Respawn").GetComponent<P1ReviveCircle>();
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
