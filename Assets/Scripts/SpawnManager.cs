using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class SpawnManager : MonoBehaviour
{
    public GameObject[] meteorPrefabs;
    private float spawnPosX = 17;
    private float spawnRangeZ = 3;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomMeteor", startDelay, spawnInterval);
    }

    void SpawnRandomMeteor()
    {
        if (UIManager.Instance.isGameActive)
        {
            // Randomly generate animal index and spawn position
            int animalIndex = Random.Range(0, meteorPrefabs.Length);
            Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ + 1));
            Instantiate(meteorPrefabs[animalIndex], spawnPos, meteorPrefabs[animalIndex].transform.rotation);
        }
        
    }
}
