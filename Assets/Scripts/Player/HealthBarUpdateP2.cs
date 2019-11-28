using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarUpdateP2 : MonoBehaviour
{
    
    public playerStats p2Stats;

    
    public float p2;

    public event System.Action<float> updateHealthP2;



    // Start is called before the first frame update
    void Start()
    {
       
        p2Stats = GameObject.FindGameObjectWithTag("Player 2").GetComponent<playerStats>();
    }

    // Update is called once per frame
    void Update()
    {
       
        p2 = p2Stats.health / p2Stats.maxHealth;
        
        updateHealthP2(p2);
    }
}
