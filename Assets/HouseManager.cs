using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseManager : MonoBehaviour
{
    private List<Plants> HousePlants = new List<Plants>();

    public void AddPlant(Plants plant)
    {
        HousePlants.Add(plant);
    }

    public int CalculateTotalPrice()
    {
        int total = 0;
        foreach (Plants plant in HousePlants)
        {
            total += plant.FinalValue();
        }
        return total;
    }
}
