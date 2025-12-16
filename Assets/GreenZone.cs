using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenZone : MonoBehaviour
{
    public Spawner spawnPlants;
    public GameManager gameManager;
    private int destroyedCount = 0;
    
        private void OnTriggerEnter(Collider other)
    {
        Plants plant = other.GetComponent<Plants>();
        if (plant != null)
        {
            int value = plant.FinalValue();

            Debug.Log("Final value for " + plant.Species + ":" + value);

            gameManager.HouseManager.AddPlant(plant);

            Destroy(other.gameObject);

          

            destroyedCount++;

            if (destroyedCount >= 8)
            {
                int totalScore = gameManager.HouseManager.CalculateTotalPrice();
                Debug.Log("Final Score: " + totalScore);

                if (gameManager.Score != null)
                {
                    gameManager.Score.text = "Final Score: " + totalScore;

                    gameManager.Score.gameObject.SetActive(true);

                }
            }
            else
            {
                spawnPlants.Spawn();
            }
        }
    }
    
}
