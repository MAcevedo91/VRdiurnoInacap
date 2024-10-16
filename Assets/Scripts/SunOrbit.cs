using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunOrbit : MonoBehaviour
{
    public Transform sun;       
    public float orbitSpeed = 10f;  
    public float orbitDistance = 5f; 
    public float rotationSpeed = 10.0f; 
    void Start()
    {
        transform.position = sun.position + new Vector3(orbitDistance, 0, 0);
    }

    void Update()
    {
        OrbitAroundSun();
    }

    void OrbitAroundSun()
    {
        // Rotar alrededor de la Tierra a una velocidad constante
        transform.RotateAround(sun.position, new Vector3(0.2f, 1, 0), orbitSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * (rotationSpeed * Time.deltaTime));

    }
}