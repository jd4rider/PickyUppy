using UnityEngine;

public class MeasureIslandRadius : MonoBehaviour
{
    void Start()
    {
        Renderer r = GetComponent<Renderer>();
        if (r != null)
        {
            float radius = r.bounds.extents.magnitude;
            Debug.Log("Approximate radius: " + radius);
        }
        else
        {
            Debug.LogWarning("No Renderer found on this GameObject.");
        }
    }
}
