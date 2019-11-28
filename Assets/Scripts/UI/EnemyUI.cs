using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyUI : MonoBehaviour
{
    public Image enemyHealthBar;

    public BossBulletDMG BHealth;



    void Awake()
    {
        
        BHealth.updateHealth += updateHealth;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        BHealth.updateHealth += updateHealth;
    }

    void updateHealth(float health)
    {
        enemyHealthBar.fillAmount = health;
    }
}
