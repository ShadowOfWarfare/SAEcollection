using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AWSpawner : MonoBehaviour
{
    
    public GameObject ammo;
    public List<GameObject> weapon;

    public bool picked = false;
    public int timer;
    public int count;


    // Start is called before the first frame update
    void Start()
    {
        GameObject A = Instantiate(ammo, transform.position, transform.rotation);
        A.GetComponent<PickUpA>().awSpawner = this;
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(waitTime());
    }

    IEnumerator waitTime()
    {
        if(picked == true)
        {

            
            yield return new WaitForSeconds(timer);
            if (count == 5 && picked == true)
            {
                picked = false;
                int W = Random.Range(0, weapon.Count);
                GameObject A = Instantiate(weapon[W], transform.position, transform.rotation);
                
                //resets the countdown for weapon spawn.
                count = 0;
            }
            if (count < 5 && picked == true)
            {
                picked = false;
                GameObject A = Instantiate(ammo, transform.position, transform.rotation);
                A.GetComponent<PickUpA>().awSpawner = this;
                
            }
        }
    }
}
