using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeManagerScript : MonoBehaviour
{
    private float currentTime;
    private float displayTime;
    private int minutes;
    private int seconds;

    private bool isTimeFrozen = false; // Flag to check if time is frozen

    [SerializeField] private TextMeshProUGUI timeText; // Reference to the TextMeshProUGUI component to display time
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isTimeFrozen)
        {
            return; // If time is frozen, skip the rest of the update
        }
        currentTime += Time.deltaTime; // Increment current time by the time since last frame
        displayTime = currentTime; // Update display time with current time 
        minutes = (int)displayTime % 3600 / 60; // Calculate minutes from display time
        seconds = (int)displayTime % 60; // Calculate seconds from display time
        timeText.text = $"{minutes:00}:{seconds:00}"; // Format and display time in MM:SS format

    }

    public void ResetTime()
    {
        currentTime = 0; // Reset current time to zero
        timeText.text = "00:00"; // Reset displayed time to 00:00
    }

    public float FreezeTime()
    {
        isTimeFrozen = true; // Set the flag to freeze time
        return currentTime; // Return the current time when called
    }

    public void RestartLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
