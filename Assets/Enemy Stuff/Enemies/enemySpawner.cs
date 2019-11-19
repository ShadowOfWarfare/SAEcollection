using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public float spawnTime;
    public float curMut;
    public float maxMut;

    public bool maxMet = false;
    //public bool spawnToggle = false;

    public GameObject enemy;

    public int spawnCount;
    public int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawning());
        spawnTime = Random.Range(2, 6);

        GameObject[] spawners = GameObject.FindGameObjectsWithTag("Spawner");
        spawnCount = spawners.Length;
    }

    void Update()
    {
        GameObject[] enemyList = GameObject.FindGameObjectsWithTag("Mutant");
        enemyCount = enemyList.Length;
        Debug.Log(enemyCount);

        if(enemyCount >= maxMut)
        {
            maxMet = true;
        }
    }
    #region Manual Spawning Code
    // Update is called once per frame
    /*
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //StartCoroutine(BreakInSpawning());
          spawnToggle = true; 
        }

        if (spawnToggle == true)
        {
            StartCoroutine(BreakInSpawning());
        }

    }
    */
    #endregion

    //This is the coroutine started earlier
    IEnumerator Spawning()
    {
        yield return new WaitForSeconds(spawnTime);
        if (maxMet == false)
        {
            //spawnToggle = false;
            yield return new WaitForSeconds(spawnTime);
            Instantiate(enemy, transform.position, transform.rotation);
            curMut += 1;
            enemyCount += 1;
            if (enemyCount < maxMut)
            {
                StartCoroutine(Spawning());
            }
        }


    }
}
