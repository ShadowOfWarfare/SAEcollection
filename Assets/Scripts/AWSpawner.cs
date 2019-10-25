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
        count++;
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
            picked = false;
            yield return new WaitForSeconds(timer);
            if (count == 5 && picked == true)
            {
                int W = Random.Range(0, weapon.Count);
                GameObject A = Instantiate(weapon[W], transform.position, transform.rotation);
                A.GetComponent<PickUpA>().awSpawner = this;
                //resets the countdown for weapon spawn.
                count = 0;
            }
            else if (count < 5 && picked == true)
            {
                GameObject A = Instantiate(ammo, transform.position, transform.rotation);
                A.GetComponent<PickUpA>().awSpawner = this;
                count++;
            }
        }
    }
}
