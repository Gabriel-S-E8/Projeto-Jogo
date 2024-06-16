using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera camera3Pessoa; 
    public Camera cameraPrimeiraPessoa; 
    public Camera cameraLateral; 

    void Start()
    {
        // Inicialmente, ative a primeira câmera e desative as outras
        camera3Pessoa.enabled = true;
        cameraPrimeiraPessoa.enabled = false;
        cameraLateral.enabled = false;
    }

    void Update()
    {
        // Se a tecla '1' for pressionada, ative a câmera 3Pessoa e desative as outras
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            camera3Pessoa.enabled = true;
            cameraPrimeiraPessoa.enabled = false;
            cameraLateral.enabled = false;
        }

        // Se a tecla '2' for pressionada, ative a câmera PrimeiraPessoa e desative as outras
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            camera3Pessoa.enabled = false;
            cameraPrimeiraPessoa.enabled = true;
            cameraLateral.enabled = false;
        }

        // Se a tecla '3' for pressionada, ative a câmera Lateral e desative as outras
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            camera3Pessoa.enabled = false;
            cameraPrimeiraPessoa.enabled = false;
            cameraLateral.enabled = true;
        }
    }
}

