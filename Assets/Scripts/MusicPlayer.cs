using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip musicClip;

    private AudioSource audioSource;

    private static MusicPlayer instance;

    void Awake()
    {
       
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        
        instance = this;

        
        DontDestroyOnLoad(gameObject);

        
        audioSource = GetComponent<AudioSource>();

        
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        if (musicClip != null)
        {
            audioSource.clip = musicClip;
            audioSource.playOnAwake = true;
            audioSource.loop = true;
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("No music clip assigned!");
        }
    }

    
    public void ToggleMusic()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
        else
        {
            audioSource.Play();
        }
    }


    public static MusicPlayer GetInstance()
    {
        return instance;
    }
}
