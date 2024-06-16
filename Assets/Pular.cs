using UnityEngine;

public class SimpleJump : MonoBehaviour
{
    public float jumpHeight = 2f; // Altura do pulo
    public float jumpDuration = 0.5f; // Duração do pulo

    private Vector3 startPosition;
    private Vector3 peakPosition;
    private bool isJumping = false;
    private float timer;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            isJumping = true;
            timer = 0;
            startPosition = transform.position; // Guarda a posição de início do pulo
            peakPosition = startPosition + Vector3.up * jumpHeight; // Calcula a posição mais alta do pulo
        }

        if (isJumping)
        {
            timer += Time.deltaTime;
            float fraction = timer / jumpDuration;

            if (fraction < 0.5f) // Subindo
            {
                transform.position = Vector3.Lerp(startPosition, peakPosition, fraction * 2);
            }
            else if (fraction < 1f) // Descendo
            {
                transform.position = Vector3.Lerp(peakPosition, peakPosition - Vector3.up * jumpHeight, (fraction - 0.5f) * 2);
            }
            else // Terminou o pulo
            {
                transform.position = peakPosition - Vector3.up * jumpHeight; // Nova posição após o pulo
                isJumping = false;
            }
        }
    }
}
