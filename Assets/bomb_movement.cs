using UnityEngine;

public class BombMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    public float speed = 3f;       // How fast the bomb moves up/down
    public float distance = 2f;    // How far from the start position it moves up/down

    private float _startY;

    void Start()
    {
        // Store the bomb's initial Y position
        _startY = transform.position.y;
    }

    void Update()
    {
        // Calculate new Y position using a sine wave
        float newY = _startY + Mathf.Sin(Time.time * speed) * distance;

        // Update bomb position
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
