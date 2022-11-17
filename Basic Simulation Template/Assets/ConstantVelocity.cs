using UnityEngine;

public class ConstantVelocity : MonoBehaviour
{
    public Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity * UnityEngine.Time.deltaTime;
    }
}
