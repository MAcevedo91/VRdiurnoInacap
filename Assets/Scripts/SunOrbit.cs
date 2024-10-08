using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunOrbit : MonoBehaviour
{
    public Transform sun;         // La Tierra a la que la Luna orbitará
    public float orbitSpeed = 10f;  // Velocidad de la órbita de la Luna
    public float orbitDistance = 5f; // Distancia desde la Tierra
    public float rotationSpeed = 10.0f; // Velocidad de rotación
    void Start()
    {
        // Coloca la Luna a la distancia adecuada de la Tierra
        transform.position = sun.position + new Vector3(orbitDistance, 0, 0);
    }

    void Update()
    {
        // Hacer que la Luna orbite alrededor de la Tierra
        OrbitAroundSun();
    }

    void OrbitAroundSun()
    {
        // Rotar alrededor de la Tierra a una velocidad constante
        transform.RotateAround(sun.position, new Vector3(0.2f, 1, 0), orbitSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * (rotationSpeed * Time.deltaTime));

    }
}