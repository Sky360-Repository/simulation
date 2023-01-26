using UnityEngine;

public class CentripetalMotion : MonoBehaviour
{
    public float accelerationG = 1;
    public Vector3 center = Vector3.zero;
    public Vector3 velocityMPS = Vector3.zero;

    public readonly float gMetersPerSecondSquared = 9.80665f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Accelerate towards the center of motion
        Vector3 direction = (center - transform.position).normalized;
        velocityMPS += (direction * accelerationG * gMetersPerSecondSquared) * Time.deltaTime;

        transform.position += velocityMPS * Time.deltaTime;
    }
}
