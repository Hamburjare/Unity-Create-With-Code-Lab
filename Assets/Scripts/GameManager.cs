using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI healthText;
    public int score;

    public int health;

    [SerializeField]
    private int maxHealth = 5;

    void Start()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        score = 0;
        health = maxHealth;
        UpdateScore(score);
        if (healthText != null)
        {
            healthText.text = $"{health}/{maxHealth}";
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        if (scoreText != null)
        {
            scoreText.text = $"{score}";
        }

    }

    public void UpdateHealth(int healthToRemove)
    {
        health -= healthToRemove;
        if (healthText != null)
        {
            healthText.text = $"{health}/{maxHealth}";
        }

    }

}
