using UnityEngine;
using TMPro;

public class TrashCounter : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    private int totalTrash;
    private int destroyedTrash;

    void Start()
    {
        // Count all trash at start
        totalTrash = GameObject.FindGameObjectsWithTag("Trash").Length;
        UpdateText();
    }

    public void TrashDestroyed()
    {
        destroyedTrash++;
        UpdateText();
        if (destroyedTrash >= totalTrash)
        {
            Debug.Log("All trash bags collected!");
            // Here you can trigger the end level logic, e.g., show a UI panel or load a new scene
            FindFirstObjectByType<TriggerEnd>().EndLevel();
        }
    }

    void UpdateText()
    {
        counterText.text = $"{destroyedTrash} / {totalTrash} Trash Bags";
    }
}
