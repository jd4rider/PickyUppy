using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int totalTrash;
    private int cleanedTrash = 0;

    public void TrashCleaned()
    {
        cleanedTrash++;
        if (cleanedTrash >= totalTrash)
        {
            Debug.Log("Level Complete!");
            // Trigger end sequence
        }
    }
}
