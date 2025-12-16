using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PickUpLilly : MonoBehaviour
{
    
    [SerializeField] TMP_Text PressEToPickup;
    [SerializeField] GameObject HandlePoint;
    GameObject Lily;
    bool IsplayerNExtToLily = false;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Lily" )
        {
            PressEToPickup.gameObject.SetActive(true);
            Lily = other.gameObject;
            IsplayerNExtToLily = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Lily")
        {
            PressEToPickup.gameObject.SetActive(false);
            IsplayerNExtToLily = false;

        }
      
           
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && IsplayerNExtToLily && Lily!= null)
        {

            Lily.transform.parent = HandlePoint.transform;
            Lily.transform.localPosition = Vector3.zero;
            Lily.transform.localRotation = Quaternion.identity;
            Lily.transform.localScale = Vector3.one;
            PressEToPickup.gameObject.SetActive(false);
            Lily = null;
            IsplayerNExtToLily = false;

            

        }
        
        
    }
}


