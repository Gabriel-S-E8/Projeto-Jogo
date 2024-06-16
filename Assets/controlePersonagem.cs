using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePersonagem : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    private Animator heroi;

    void Start()
    {
        heroi = GetComponent<Animator>();
    }

    void Update()
{
    bool isMoving = false;

    if (Input.GetKey(KeyCode.W))
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        isMoving = true;
    }
    else if (Input.GetKey(KeyCode.S))
    {
        transform.Translate(-Vector3.forward * Time.deltaTime * speed);
        isMoving = true;
    }

    if (Input.GetKey(KeyCode.A))
    {
        transform.Rotate(0, -1, 0);
        isMoving = true;
    }
    else if (Input.GetKey(KeyCode.D))
    {
        transform.Rotate(0, 1, 0);
        isMoving = true;
    }

    // Verifica se o botão do mouse foi pressionado
    if (Input.GetMouseButtonDown(0)) // 0 é o botão esquerdo do mouse
    {
        StartCoroutine(Dash());
    }


    heroi.SetBool("Correndo", isMoving);
    heroi.SetBool("Parado", !isMoving);
}

IEnumerator Dash()
{
    float startTime = Time.time;
    Vector3 startPosition = transform.position;
    Vector3 endPosition = transform.position + Vector3.forward * 4; // Ajuste o valor '2' para o tamanho do impulso que você deseja
    float dashDuration = 0.2f; // Ajuste a duração do dash conforme necessário

    while (Time.time < startTime + dashDuration)
    {
        transform.position = Vector3.Lerp(startPosition, endPosition, (Time.time - startTime) / dashDuration);
        yield return null;
    }

    transform.position = endPosition; // Garante que o personagem chegue na posição final
}

}
