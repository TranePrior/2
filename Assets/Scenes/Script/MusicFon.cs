using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip[] musicClips;
    private AudioSource audioSource;
    private int currentClipIndex = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayNextClip();
    }

    void Update()
    {
        if (!audioSource.isPlaying)
        {
            PlayNextClip();
        }
    }

    void PlayNextClip()
    {
        if (currentClipIndex >= musicClips.Length)
        {
            currentClipIndex = 0;
        }

        audioSource.clip = musicClips[currentClipIndex];
        audioSource.Play();

        currentClipIndex++;
    }
}
