using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class SpawnManager : MonoBehaviour
{
    public Button quitButton;
    public Button resumeButton;
    public TextMeshProUGUI pauseText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI scoreText;
    public GameObject[] meteorPrefabs;
    private int score;
    private float spawnPosX = 17;
    private float spawnRangeZ = 3;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    public bool isGameActive;
    public Button restartButton;

    void Start()
    {
        score = 0;
        UpdateScore(score);
        isGameActive = true;
        InvokeRepeating("SpawnRandomMeteor", startDelay, spawnInterval);
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        isGameActive=false;
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void PauseMenu()
    {
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
        pauseText.gameObject.SetActive(true);
        resumeButton.gameObject.SetActive(true);
        quitButton.gameObject.SetActive(true);
    }

    public void ResumeButton()
    {
        isGameActive = true;
        restartButton.gameObject.SetActive(false);
        pauseText.gameObject.SetActive(false);
        resumeButton.gameObject.SetActive(false);
        quitButton.gameObject.SetActive(false);
    }
    public void QuitButton()
    {
        Application.Quit();
    }

    void SpawnRandomMeteor()
    {
        if (isGameActive)
        {
            // Randomly generate animal index and spawn position
            int animalIndex = Random.Range(0, meteorPrefabs.Length);
            Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ + 1));
            Instantiate(meteorPrefabs[animalIndex], spawnPos, meteorPrefabs[animalIndex].transform.rotation);
        }
        
    }
}
