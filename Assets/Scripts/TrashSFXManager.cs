using UnityEngine;


public class TrashSFXManager : MonoBehaviour
{
    [SerializeField] AudioClip[] trashSFXClips; // Array to hold different trash sound effects

    private AudioSource audioSource; // AudioSource component to play sound effects
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component attached to this GameObject
    }

    // Update is called once per frame
    public void PlayRandomTrashSFX()
    {
        if (trashSFXClips.Length > 0)
        { 
            int randomIndex = Random.Range(0, trashSFXClips.Length); // Get a random index from the array
            audioSource.PlayOneShot(trashSFXClips[randomIndex]); // Play the selected sound effect
        }
    }
}
