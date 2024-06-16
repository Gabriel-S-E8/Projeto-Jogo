using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DayNightCycle : MonoBehaviour
{
    // Defina a luz do sol em seu cenário
    public Light sun;

    // Defina as intensidades da luz para o dia e a noite
    public float dayIntensity = 1f;
    public float nightIntensity = 0.2f;

    void Update()
    {
        // Verifique se a tecla 'Q' foi pressionada
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Se for dia, mude para noite. Se for noite, mude para dia.
            if (sun.intensity == dayIntensity)
            {
                sun.intensity = nightIntensity;
            }
            else
            {
                sun.intensity = dayIntensity;
            }
        }
    }
}
