using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{

    public float baseDamage = 10f;

    void OnTriggerEnter(Collider other)
    {
    if (other.gameObject.CompareTag("Daisy") || other.gameObject.CompareTag("Cactus") || other.gameObject.CompareTag("Lily"))
     {
     Plants plant = other.gameObject.GetComponent<Plants>();
            if (plant != null)
            {

                plant.TakeDamage(baseDamage);
                
     }

            Debug.Log("Oops We got damage");

     }
     }
}