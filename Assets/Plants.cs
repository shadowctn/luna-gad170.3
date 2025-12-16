using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plants : MonoBehaviour
{
    public string Species;
    public int BaseValue;
    public float Health;
    public float Fragility;
    public int FinalValue()
    {

        float caclculated = BaseValue * (Health / 100);
        return Mathf.RoundToInt(caclculated);
    }
    public void TakeDamage(float BaseDamage)
    {

        float totalDamage = BaseDamage * Fragility;
        Health -= totalDamage;
        if (Health <= 0)
        {
            Health = 0.0f;
        }
    

    }

}
