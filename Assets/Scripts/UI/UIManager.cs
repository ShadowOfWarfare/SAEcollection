using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public Image p1healthBarFill;
    public Image p2healthBarFill;

    public HealthBarUpdateP1 p1hp;
    public HealthBarUpdateP2 p2hp;

    public playerStats p1Stats;
    public playerStats p2Stats;


    public Transform p1AmmoCounter;
    public Transform p2AmmoCounter;



    void Awake()
    {
        p1hp = GameObject.FindGameObjectWithTag("Player 1").GetComponent<HealthBarUpdateP1>();
        p1hp.updateHealthP1 += updateHealthP1;
        p2hp = GameObject.FindGameObjectWithTag("Player 2").GetComponent<HealthBarUpdateP2>();
        p2hp.updateHealthP2 += updateHealthP2;
        p1Stats = GameObject.FindGameObjectWithTag("Player 1").GetComponent<playerStats>();
        p2Stats = GameObject.FindGameObjectWithTag("Player 2").GetComponent<playerStats>();
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
        p1AmmoCounter.GetComponent<Text>().text = p1Stats.curAmmo.ToString();
        p2AmmoCounter.GetComponent<Text>().text = p2Stats.curAmmo.ToString();
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
        p2healthBarFill.fillAmount = health;
    }

    public void traveltoMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
