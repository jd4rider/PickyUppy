using UnityEngine;

public class TriggerEnd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Canvas endLevelCanvas; // Reference to the end level UI canvas
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EndLevel()
    {
        // Logic to end the level, e.g., load a new scene or display a completion message
        Debug.Log("Level Ended!");
        // You can add more functionality here, like transitioning to a new scene or showing a UI panel
        // make current canvas active
        //
        endLevelCanvas.enabled = true;
        Time.timeScale = 0f; // freeze game
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
