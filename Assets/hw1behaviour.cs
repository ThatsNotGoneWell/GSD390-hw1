using UnityEngine;

public class HW1Behaviour : MonoBehaviour
{
    // --- Attribute (1/3): lets you edit private values in the Inspector
    [SerializeField] private float rotationSpeed = 90f;

    // --- Static (2/3): shared across all instances
    public static int activeObjects = 0;

    // --- Property (3/3): read-only from outside
    public float CurrentRotation { get; private set; }

    void Start()
    {
        activeObjects++;
        Debug.Log("Active HW1 objects: " + activeObjects);
    }

    void Update()
    {
        CurrentRotation += rotationSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, CurrentRotation, 0);

        Debug.Log("Rotation: " + CurrentRotation);
    }
}
