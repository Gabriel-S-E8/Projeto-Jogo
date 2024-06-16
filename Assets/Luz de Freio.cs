using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrakeLights : MonoBehaviour
{
    // Defina as luzes de freio do seu carro
    public Light brakeLights;

    void Update()
    {
        // Verifique se o carro está freando
        if (Input.GetKey(KeyCode.Space))
        {
            // Se o carro estiver freando, ligue as luzes de freio
            brakeLights.enabled = true;
        }
        else
        {
            // Se o carro não estiver freando, desligue as luzes de freio
            brakeLights.enabled = false;
        }
    }
}

