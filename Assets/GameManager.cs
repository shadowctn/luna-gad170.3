using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
      public Spawner spawnPlants;
    public HouseManager HouseManager;
    public int currentRun = 0;
    public TMP_Text Score;


    void Start()
    {
        StartRun();
        Score.gameObject.SetActive(false);
    }

    public void StartRun()
    {
        if (currentRun < 5)
        {
            spawnPlants.Spawn();
            Score.gameObject.SetActive(false);
        }
    }
}
