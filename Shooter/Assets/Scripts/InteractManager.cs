using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractManager : MonoBehaviour
{
    [SerializeField]
    private LayerMask layerMask;

    [SerializeField]
    private float interactDistance;

    [SerializeField]
    private Transform cameraPosition;

    [SerializeField]
    private int medicineEffect;

    [SerializeField]
    private Image interactImage;

    private void Start(){
        interactImage.gameObject.SetActive(false);
    }

       private void Update(){
        // origin - откуда исходит луч, direction - направление
        Ray ray = new Ray(cameraPosition.position, cameraPosition.forward);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, interactDistance, layerMask)){
            interactImage.gameObject.SetActive(true);            
            // если нажата клавиша E
            if(Input.GetKeyDown(KeyCode.E)){

                if(hit.collider.tag == "Medicine"){

                    PlayerStats.HealthPoint += medicineEffect;

                    Destroy(hit.collider.gameObject);
                }
                else{
                    
                }
            }                        
        }
        else{
            interactImage.gameObject.SetActive(false);
        }         
    }
}
