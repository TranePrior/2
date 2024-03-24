using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip[] musicClips; // Массив аудиофайлов
    private AudioSource audioSource;
    private int currentClipIndex = 0;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayNextClip();
    }

    void Update()
    {
        // Если текущий клип закончился, воспроизводим следующий
        if (!audioSource.isPlaying)
        {
            PlayNextClip();
        }
    }

    void PlayNextClip()
    {
        // Если все клипы были воспроизведены, начинаем сначала
        if (currentClipIndex >= musicClips.Length)
        {
            currentClipIndex = 0;
        }

        // Воспроизводим следующий клип
        audioSource.clip = musicClips[currentClipIndex];
        audioSource.Play();

        // Переходим к следующему клипу
        currentClipIndex++;
    }
}
