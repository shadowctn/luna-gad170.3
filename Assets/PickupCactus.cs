using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickupCactus : MonoBehaviour
{
    
    [SerializeField] TMP_Text PickUp;
    [SerializeField] GameObject HandlePoint;
    GameObject Cactus;
    bool IsplayerNExtToCactus = false;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Cactus" )
        {
            PickUp.gameObject.SetActive(true);
            Cactus = other.gameObject;
            IsplayerNExtToCactus = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Cactus")
        {
            PickUp.gameObject.SetActive(false);
            IsplayerNExtToCactus = false;

        }
      
           
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && IsplayerNExtToCactus && Cactus!= null)
        {

            Cactus.transform.parent = HandlePoint.transform;
            Cactus.transform.localPosition = Vector3.zero;
            Cactus.transform.localRotation = Quaternion.identity;
            Cactus.transform.localScale = Vector3.one;
            PickUp.gameObject.SetActive(false);
           Cactus = null;
            IsplayerNExtToCactus = false;

            

        }
        
        
    }
}


