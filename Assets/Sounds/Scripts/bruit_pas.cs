using UnityEngine;

public class FootstepsPosition : MonoBehaviour
{
    [Header("Audio")]
    public AudioSource audioSource;      // Ton AudioSource avec le son de pas
    public float stepInterval = 0.5f;    // Intervalle entre les pas
    public float moveThreshold = 0.01f;  // Déplacement minimal pour déclencher un pas

    private Vector3 lastPosition;
    private float stepTimer;

    void Start()
    {
        // Position initiale
        lastPosition = transform.position;
        stepTimer = 0f;
    }

    void Update()
    {
        // Calculer le déplacement réel
        float distanceMoved = Vector3.Distance(transform.position, lastPosition);

        if (distanceMoved > moveThreshold)
        {
            // Si on bouge, incrémenter le timer
            stepTimer += Time.deltaTime;

            if (stepTimer >= stepInterval)
            {
                audioSource.PlayOneShot(audioSource.clip);
                stepTimer = 0f;
            }
        }
        else
        {
            // Si on ne bouge pas, réinitialiser le timer
            stepTimer = 0f;
        }

        // Sauvegarder la position actuelle pour le prochain frame
        lastPosition = transform.position;
    }
}