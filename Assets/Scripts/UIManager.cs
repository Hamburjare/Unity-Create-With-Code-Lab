using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif



public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public Button quitButton;
    public Button resumeButton;
    public TextMeshProUGUI pauseText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI scoreText;
    private int score;
    public bool isGameActive;
    public Button restartButton;

    void Start()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        score = 0;
        UpdateScore(score);
        isGameActive = true;
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = $"{score}";
    }

    public void GameOver()
    {
        isGameActive = false;
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
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
                Application.Quit();
#endif
    }
}
