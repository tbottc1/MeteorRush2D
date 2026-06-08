using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;

    public AudioClip enemyExplosionClip;

    public AudioClip playerDeathClip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayEnemyExplosion()
    {
        Debug.Log("enemy explosion sound called.");
        audioSource.PlayOneShot(enemyExplosionClip);
    }

    public void PlayPlayerDeath()
    {
        Debug.Log("Player death sound called.");
        audioSource.PlayOneShot(playerDeathClip);
    }
}
