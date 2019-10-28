using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject Spawn;

    public WeaponSpawner spawn;


    // Start is called before the first frame update
    void Start()
    {
        GameObject S = Instantiate(Spawn, transform.position, transform.rotation);
        S.transform.parent = transform;
    }

    // Update is called once per frame
    public void spawnUpdate()
    {
        GameObject W = Instantiate(spawn.newSpawn, transform.position, transform.rotation);
        W.transform.parent = transform;
        
    }
    
    void Update()
    {
        
    }
}
