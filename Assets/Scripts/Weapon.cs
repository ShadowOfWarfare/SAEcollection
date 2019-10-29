using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public List<GameObject> Spawn;

    public Wspawner WE;

    public Transform weaponTF;
    



    // Start is called before the first frame update
    void Start()
    {
        GameObject S = Instantiate(Spawn[0],transform.position, transform.rotation);
       
        S.transform.parent = transform;
    }

    // Update is called once per frame
    public void spawnUpdate()
    {
        Destroy(transform.GetChild(0).gameObject);

        GameObject S = Instantiate(Spawn[2], weaponTF.position, weaponTF.rotation);
        //S.GetComponent<PickWeapon>().W = this;
        S.transform.parent = transform;
    }
    
    void Update()
    {
        
    }
}
