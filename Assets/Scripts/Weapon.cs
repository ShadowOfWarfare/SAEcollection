using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public List<GameObject> Spawn;

    public Wspawner WE;

    public Transform weaponTF;

    public int n = 0;

    public playerStats pStats;
    



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

        if (n == 0)
        {
            GameObject S = Instantiate(Spawn[2], weaponTF.position, weaponTF.rotation);
            //S.GetComponent<PickWeapon>().W = this;
            S.transform.parent = transform;
            n = 1;
          
            pStats.GetComponent<playerStats>().curAmmo = 50;
            pStats.GetComponent<playerStats>().maxAmmo = 100;
            pStats.GetComponent<playerStats>().attack = 20;
        }
        else if(n == 1)
        {
            GameObject S = Instantiate(Spawn[1], weaponTF.position, weaponTF.rotation);
            //S.GetComponent<PickWeapon>().W = this;
            S.transform.parent = transform;
            n = 0;
            pStats.GetComponent<playerStats>().curAmmo = 30;
            pStats.GetComponent<playerStats>().maxAmmo = 100;
            pStats.GetComponent<playerStats>().attack = 40;
        }
    }
    
    void Update()
    {
        
    }
}
