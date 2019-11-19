using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eBulletSpawner : MonoBehaviour
{
    public GameObject projectile;
    public bool canFire = false;
    public bool firing;
    public float enemyRPM;

    // Update is called once per frame
    void Update()
    {
        if (canFire == true && !firing)
        {
            StartCoroutine(enemyShoot());
        }
    }

    IEnumerator enemyShoot()
    {
        canFire = false;
        firing = true;
        yield return new WaitForSeconds(enemyRPM);
        Instantiate(projectile, transform.position, transform.rotation);
        Debug.Log("Enemy Fired!");
        canFire = true;
        firing = false;


    }
}
