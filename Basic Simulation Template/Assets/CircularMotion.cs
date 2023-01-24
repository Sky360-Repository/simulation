using UnityEngine;

public class CircularMotion : MonoBehaviour
{
    public float centripetalAcceleration = 1;
    public Vector3 center = Vector3.zero;
    public Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity * Time.deltaTime;

        // Accelerate towards the center of motion
        Vector3 direction = (center - transform.position).normalized;
        velocity += (direction * centripetalAcceleration) * Time.deltaTime;
    }
}
