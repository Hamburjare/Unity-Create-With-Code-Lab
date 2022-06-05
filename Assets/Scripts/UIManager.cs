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

    public GameObject pauseUI;
    public GameObject gameOverUI;
    
    public bool isGameActive;

    void Start()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        
        isGameActive = true;
    }

    

    public void GameOver()
    {
        isGameActive = false;
        gameOverUI.gameObject.SetActive(true);

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void PauseMenu()
    {
        isGameActive = false;
        pauseUI.gameObject.SetActive(true);
    }

    public void ResumeButton()
    {
        isGameActive = true;
        pauseUI.gameObject.SetActive(false);
        gameOverUI.gameObject.SetActive(false);
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
