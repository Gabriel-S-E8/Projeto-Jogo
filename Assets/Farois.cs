using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarHeadlights : MonoBehaviour
{
    // Defina os faróis do seu carro
    public Light headlights;

    void Update()
    {
        // Verifique se a tecla 'E' foi pressionada
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Se os faróis estiverem ligados, desligue-os. Se estiverem desligados, ligue-os.
            headlights.enabled = !headlights.enabled;
        }
    }
}
