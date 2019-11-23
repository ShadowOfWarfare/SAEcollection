using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemySpawner : MonoBehaviour
{
    public float spawnTime;
    public float curMut;
    public float maxMut;
    public float waveRestart;

    public bool maxMet = false;
    //public bool spawnToggle = false;

    public List<GameObject> enemy;
    //public GameObject rangedEnemy;

    public int spawnCount;
    public int enemyCount;
    public int waveCount;

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
        //Debug.Log(enemyCount);

        if(enemyCount >= maxMut)
        {
            maxMet = true;
        }

        if (maxMet == true && enemyCount == 0)
        {
            waveCount += 1;
            maxMet = false;
            StartCoroutine(Spawning());
        }
        if(waveCount == 1)
        {
            SceneManager.LoadScene("BossLevel");
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
        yield return new WaitForSeconds(waveRestart);
        if (maxMet == false)
        {
            //spawnToggle = false;
            yield return new WaitForSeconds(spawnTime);
            Instantiate(enemy[Random.Range(0,2)], transform.position, transform.rotation);
            curMut += 1;
            enemyCount += 1;
            if (enemyCount < maxMut)
            {
                StartCoroutine(Spawning());
            }


        }
    }

    

}
