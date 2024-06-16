using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAndFloat : MonoBehaviour
{
    public float rotationSpeed = 50f; // Velocidade de rotação
    public float floatSpeed = 0.5f; // Velocidade de flutuação
    public float floatAmplitude = 0.5f; // Amplitude de flutuação

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position; // Armazena a posição inicial do objeto
    }

    void Update()
    {
        // Faz o objeto girar em torno do seu eixo Y
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

        // Faz o objeto flutuar para cima e para baixo
        float newY = initialPosition.y + Mathf.Sin(Time.time * floatSpeed) * floatAmplitude;
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
