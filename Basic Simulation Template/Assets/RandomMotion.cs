using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMotion : MonoBehaviour
{
    public float maximumSpeed = 100; // meters per second

    // Gets a random normalized direction vector
    Vector3 RandomDirection()
    {
        Vector3 direction = Vector3.zero;

        direction.x = UnityEngine.Random.Range(-1.0f, 1.0f);
        direction.y = UnityEngine.Random.Range(-1.0f, 1.0f);
        direction.z = UnityEngine.Random.Range(-1.0f, 1.0f);

        return direction.normalized;
    }

    // Gets a random velocity on the range [0, maximumSpeed]
    float RandomSpeed()
    {
        return UnityEngine.Random.Range(0.0f, maximumSpeed);
    }


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += RandomDirection() * RandomSpeed() * UnityEngine.Time.deltaTime;
    }
}
