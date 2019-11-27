using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarUpdateP1 : MonoBehaviour
{
    public playerStats p1Stats;
    

    public float p1;
    

    public event System.Action<float> updateHealthP1;



    // Start is called before the first frame update
    void Start()
    {
        p1Stats = GameObject.FindGameObjectWithTag("Player 1").GetComponent<playerStats>();
        
    }

    // Update is called once per frame
    void Update()
    {
        p1 = p1Stats.health / p1Stats.maxHealth;
        
        updateHealthP1(p1);
       
    }
}
