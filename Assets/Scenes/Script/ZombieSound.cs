using UnityEngine;

public class Zombie : MonoBehaviour
{
    public AudioClip isAttacking;
    public AudioClip Run;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayAttackSound()
    {
        audioSource.PlayOneShot(isAttacking);
    }

    public void PlayRunSound()
    {
        audioSource.PlayOneShot(Run);
    }
}
