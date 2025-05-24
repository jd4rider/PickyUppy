using UnityEngine;

public class CircularBarrierBuilder : MonoBehaviour
{
    [Header("Barrier Settings")]
    public int numberOfSegments = 16;
    public float radius = 25f;
    public float wallWidth = 1f;
    public float wallHeight = 10f;
    public float wallThickness = 0.2f;

    [Header("Wall Material (Optional)")]
    public Material invisibleMaterial;

    void Start()
    {
        GenerateBarrier();
    }

    void GenerateBarrier()
    {
        for (int i = 0; i < numberOfSegments; i++)
        {
            float angle = i * Mathf.PI * 2f / numberOfSegments;
            Vector3 position = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;

            GameObject wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
            wall.name = $"BarrierWall_{i}";
            wall.transform.parent = transform;
            Vector3 directionToCenter = (transform.position - position).normalized;
            Vector3 tangent = Vector3.Cross(Vector3.up, directionToCenter);

            wall.transform.position = position + new Vector3(0, wallHeight / 2f, 0);
            wall.transform.localScale = new Vector3(wallThickness, wallHeight, wallWidth);
            wall.transform.rotation = Quaternion.LookRotation(tangent, Vector3.up);// rotate toward center

            if (invisibleMaterial != null)
            {
                wall.GetComponent<MeshRenderer>().material = invisibleMaterial;
            }
            else
            {
                wall.GetComponent<MeshRenderer>().enabled = false; // hide if no material
            }

            wall.layer = LayerMask.NameToLayer("Default"); // or set to custom layer
        }
    }
}
