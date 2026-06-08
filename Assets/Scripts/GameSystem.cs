using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameSystem : MonoBehaviour
{
    public int score = 0;

    public TMP_Text scoreText;
    public TMP_Text gameOverText;
    public TMP_Text finalScoreText;
    public TMP_Text restartText;

    private bool gameOver = false;

    void Start()
    {
        UpdateScoreUI();

        gameOverText.gameObject.SetActive(false);
        finalScoreText.gameObject.SetActive(false);
        restartText.gameObject.SetActive(false);
    }

    void Update()
    {
        if (gameOver && Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void AddScore(int amount)
    {
        if (gameOver)
            return;

        score += amount;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameOver = true;

        gameOverText.gameObject.SetActive(true);
        finalScoreText.gameObject.SetActive(true);
        restartText.gameObject.SetActive(true);

        finalScoreText.text = "Final Score: " + score;
    }
}