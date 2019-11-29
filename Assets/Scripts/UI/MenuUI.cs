using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{

    
    public Button BonusLvl;
    public bool unlock;
    public DontDestroy Dd;

    void Awake()
    {
        //BB = GameObject.FindGameObjectWithTag("Boss").GetComponent<BossBulletDMG>();
        BonusLvl.interactable = false;
        
    }

    void Start()
    {
        
            Dd = GameObject.FindGameObjectWithTag("GG").GetComponent<DontDestroy>();
        
        
            
        if (Dd != null)
        {
            if (Dd.unlock == true)
            {
                BonusLvl.interactable = true;
            }
        }
        
    }

    public void traveltoworld()
    {

        //SceneManager.LoadScene("Level 1");
        unlock = true;
        SceneManager.LoadScene("Level 1");

    }

    public void Unlocked()
    {
        SceneManager.LoadScene("BonusLevel");
    }

  
        
    
}
