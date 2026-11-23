using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    public AudioClip shootSound;
    public AudioClip explosionSound;
    public AudioClip gameOverSound;
    public AudioClip backgroundMusic;

    public AudioSource soundEffectsSource;
    public AudioSource musicSource;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        PlayBackgroundMusic();
    }

    public void PlayShootSound()
    {
        PlaySound(shootSound);
    }

    public void PlayExplosionSound()
    {
        PlaySound(explosionSound);
    }

    public void PlayGameOverSound()
    {

        if (musicSource != null)
        {
            musicSource.Stop();
        }

        PlaySound(gameOverSound);
    }

    public void PlayBackgroundMusic()
    {
        if (backgroundMusic != null && musicSource != null)
        {
            musicSource.clip = backgroundMusic;
            musicSource.loop = true;
            musicSource.Play();
        }
    }
    public void StopBackgroundMusic()
    {
        if (musicSource != null && musicSource.isPlaying)
        {
            musicSource.Stop();
        }
    }

    private void PlaySound(AudioClip clip)
    {
        if (clip != null && soundEffectsSource != null)
        {
            soundEffectsSource.PlayOneShot(clip);
        }
    }
}