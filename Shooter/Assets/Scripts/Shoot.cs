using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private LayerMask layerMask;

    [SerializeField]
    private float interactDistance;

    [SerializeField]
    private int damage;

    [SerializeField]
    private Transform weaponPosition;


    [SerializeField]
    private GameObject Effect;

    [SerializeField]
    private GameObject EnemyEffect;

    [SerializeField]
    private GameObject HoleEffect;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButton(0)){
        Ray ray = new Ray(weaponPosition.position, weaponPosition.forward);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, interactDistance, layerMask)){
               if(hit.collider.tag == "Wall"){ 
                Instantiate(HoleEffect,hit.point,Quaternion.identity); 
               }  
               if(hit.collider.tag == "Obstacle"){
                Instantiate(Effect,hit.point,Quaternion.identity); 
                var obstacle = hit.transform.GetComponent<Obstalce>();

                obstacle.DamageToObstacles(damage);
               }
                if(hit.collider.tag == "Enemy"){
                Instantiate(EnemyEffect,hit.point,Quaternion.identity); 
                var enemy = hit.transform.GetComponent<Enemis>();

                enemy.DamageToEnemy(damage);
   
               }

            }
        }
    }
}
