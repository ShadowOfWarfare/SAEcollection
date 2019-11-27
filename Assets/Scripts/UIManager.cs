using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Image p1healthBarFill;
    public Image p2healthBarFill;

    public HealthBarUpdateP1 p1hp;
    public HealthBarUpdateP2 p2hp;

   

    void Awake()
    {
        p1hp = GameObject.FindGameObjectWithTag("Player 1").GetComponent<HealthBarUpdateP1>();
        p1hp.updateHealthP1 += updateHealthP1;
        p2hp = GameObject.FindGameObjectWithTag("Player 2").GetComponent<HealthBarUpdateP2>();
        p2hp.updateHealthP2 += updateHealthP2;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        p1hp = GameObject.FindGameObjectWithTag("Player 1").GetComponent<HealthBarUpdateP1>();
        p1hp.updateHealthP1 += updateHealthP1;
        p2hp = GameObject.FindGameObjectWithTag("Player 2").GetComponent<HealthBarUpdateP2>();
        p2hp.updateHealthP2 += updateHealthP2;
        //p1Stats = GameObject.FindGameObjectWithTag("Player 1").GetComponent<playerStats>();
        //p1Stats.updateHealth += updateHealth;
        //p2Stats = GameObject.FindGameObjectWithTag("Player 2").GetComponent<playerStats>();
        //p2Stats.updateHealth += updateHealth;
    }

    public void updateHealthP1(float health)
    {
        p1healthBarFill.fillAmount = health;
    }
    public void updateHealthP2(float health)
    {
        p1healthBarFill.fillAmount = health;
    }
}
