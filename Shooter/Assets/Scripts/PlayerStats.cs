using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerStats : MonoBehaviour
{
    public static int HealthPoint;
    public static int killCount;
    

    [SerializeField]
    private int startHp;
    

    [SerializeField]
    private Text hpShow;

    [SerializeField]
    private Text killCountShow;

    private void Start()
    { 
        HealthPoint = startHp;   
    }

    // Update is called once per frame
    private void Update()
    {
        hpShow.text = HealthPoint.ToString();
        killCountShow.text = killCount.ToString();
        if(killCount >= 10){
            SceneManager.LoadScene("Menu");
        }
    }

}
