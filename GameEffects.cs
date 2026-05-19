using UnityEngine;

public class GameEffects : MonoBehaviour
{
    public ParticleSystem explosionEffect;
    public AudioSource coinSound;

    public void PlayExplosion(Vector3 position)
    {
        Instantiate(explosionEffect, position, Quaternion.identity);
    }

    public void PlayCoinSound()
    {
        coinSound.Play();
    }
}
