using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemis : MonoBehaviour
{


    [SerializeField]
    private int startHp;
   public void DamageToEnemy(int damage)
    {
        startHp -= damage;
        if (startHp <= 0)
        {
            Destroy(transform.gameObject);
            PlayerStats.killCount += 1;
            Debug.Log(PlayerStats.killCount);
        }
    }

}
