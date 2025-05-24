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
    }

    void UpdateText()
    {
        counterText.text = $"{destroyedTrash} / {totalTrash} Trash Removed";
    }
}
