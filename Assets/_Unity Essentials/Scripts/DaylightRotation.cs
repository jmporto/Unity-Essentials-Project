using UnityEngine;

public class DaylightRotation : MonoBehaviour
{
    // Duration for a full day in seconds
    [SerializeField]
    private float dayDuration = 60f; // Default to 60 seconds for a full day

    // Update is called once per frame
    void Update()
    {
        // Calculate the rotation speed based on the day duration
        float rotationSpeed = 360f / dayDuration * Time.deltaTime;

        // Rotate the light around the X-axis
        transform.Rotate(rotationSpeed, 0, 0);
    }
}
