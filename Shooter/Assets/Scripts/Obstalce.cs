using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstalce : MonoBehaviour
{

    [SerializeField]
    private int startHp;
   public void DamageToObstacles(int damage)
    {
        startHp -= damage;
        if (startHp <= 0)
        {
            Destroy(transform.gameObject);
        }
    }
}
