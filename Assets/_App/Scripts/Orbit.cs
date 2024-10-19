using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    // Reference to the Earth object
    public Transform earth;

    // Orbit speed of the moon
    public float orbitSpeed = 10f;

    // Distance from the Earth (can be adjusted in Unity editor)
    public float distanceFromEarth = 1.5f;

    void Update()
    {
        // Keep the moon at a fixed distance from the Earth
        Vector3 direction = (transform.position - earth.position).normalized;
        transform.position = earth.position + direction * distanceFromEarth;

        // Rotate the moon around the Earth
        transform.RotateAround(earth.position, Vector3.up, orbitSpeed * Time.deltaTime);
    }
}
