using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PIckupDaisy : MonoBehaviour
{
    [SerializeField] TMP_Text PressEToPickup;
    [SerializeField] GameObject Handlepoint;
    GameObject Daisy;
    bool IsplayerNExtToDaisy = false;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Daisy" )
        {
            PressEToPickup.gameObject.SetActive(true);
            Daisy = other.gameObject;
            IsplayerNExtToDaisy = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Daisy")
        {
            PressEToPickup.gameObject.SetActive(false);
            IsplayerNExtToDaisy = false;

        }
      
           
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && IsplayerNExtToDaisy && Daisy!=null)
        {

            Daisy.transform.parent = Handlepoint.transform;
            Daisy.transform.localPosition = Vector3.zero;
            Daisy.transform.localRotation = Quaternion.identity;
            Daisy.transform.localScale = Vector3.one;
            PressEToPickup.gameObject.SetActive(false);
           Daisy = null;
            IsplayerNExtToDaisy = false;

            

        }
        
        
    }
}
