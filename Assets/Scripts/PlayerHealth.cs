using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int lives = 3;

    public Image[] lifeImages;

    public void TakeDamage()
    {
        lives--;

        Debug.Log("Player hit! Lives left: " + lives);

        UpdateLivesUI();

        if (lives <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        FindAnyObjectByType<AudioManager>().PlayPlayerDeath();

        FindAnyObjectByType<GameSystem>().GameOver();
        gameObject.SetActive(false);
    }

    void UpdateLivesUI()
    {
        for (int i = 0; i < lifeImages.Length; i++)
        {
            if (i < lives)
            {
                lifeImages[i].gameObject.SetActive(true);
            }
            else
            {
                lifeImages[i].gameObject.SetActive(false);
            }
        }
    }

    public void InstantDeath()
    {
        lives = 0;

        UpdateLivesUI();

        Die();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateLivesUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
