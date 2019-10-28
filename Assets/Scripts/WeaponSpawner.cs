using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{
    public List<GameObject> weapons;
    public Weapon w;
    public bool picked = false;
    public int timer;
    
    public GameObject newSpawn; 

    void start()
    {
        //spawns the initial weapon
        newSpawn = weapons[Random.Range(0, weapons.Count)];
        Instantiate(newSpawn, transform.position, transform.rotation);
        Debug.Log("spawned");
    }

    private void OnTriggerEnter(Collider col)
    {
        //destroys the current held gun
        Destroy(w.gameObject);
        //spawns the new gun
        w.spawnUpdate();
        //destroys the pick up object
        Destroy(gameObject);
        
    }
    void Update()
    {
        StartCoroutine(spawner());
    }

    IEnumerator spawner()
    {
       
        if(picked == true)
        {
            yield return new WaitForSeconds(timer);
            Instantiate(newSpawn, transform.position, transform.rotation);
            picked = false;
        }
    }
}
