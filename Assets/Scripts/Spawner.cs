using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public GameObject pickup;
    public bool picked = false;
    

    // Update is called once per frame
    void Start()
    {
        GameObject P = Instantiate(pickup, transform.position, transform.rotation);
        P.GetComponent<PickUpH>().spawn = this;

    }

    void Update()
    {
        StartCoroutine(waitTime());
    }  
    
    IEnumerator waitTime()
    {
        
        if (picked == true)
        {
            picked = false;
            yield return new WaitForSeconds(3f);
            GameObject P = Instantiate(pickup, transform.position, transform.rotation);
            P.GetComponent<PickUpH>().spawn = this;
            
        }
    }
}
