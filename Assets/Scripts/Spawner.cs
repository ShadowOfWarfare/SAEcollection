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
        Instantiate(pickup, transform.position, transform.rotation);
    }

    void Update()
    {
        StartCoroutine(waitTime());
    }  
    
    IEnumerator waitTime()
    {
        
        if (picked == true)
        {
            yield return new WaitForSeconds(3f);
            Instantiate(pickup, transform.position, transform.rotation);
        }
    }
}
