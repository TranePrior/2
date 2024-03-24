using UnityEngine;

public class Zombie : MonoBehaviour
{
    public AudioClip isAttacking; // Загрузите звук атаки зомби
    public AudioClip Run; // Загрузите звук бега зомби
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Этот метод вызывается из события анимации атаки
    public void PlayAttackSound()
    {
        audioSource.PlayOneShot(isAttacking);
    }

    // Этот метод вызывается из события анимации бега
    public void PlayRunSound()
    {
        audioSource.PlayOneShot(Run);
    }
}
