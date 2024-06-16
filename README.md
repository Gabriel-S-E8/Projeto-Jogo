# Meu nome e gabriel Ferrira da Silva e venho falar um pouco sobre o Meu jogo Apocalipse 8000

## sobre o Jogo e Funcionalidades
o jogo ele tem um tema de zumbis ambientado em uma cidadezinha onde se vc chegar perto o zumbi corre atras de vc ou dos outros npc. Ele tem funcionalidades simples wasd andam como outros jogos o espaço pula e ao clicar com o botao esquedo do mouse voce dara um dash para frente. tambem temos algumas outras funcionalidades como alterar o dia para noite apertando o q.

## Video Curto da Gameplay e explicando algumas coisas Com a imagem do Menu do Jogo.
[![Vídeo de Apresentação](https://github.com/Gabriel-S-E8/Projeto-Jogo/blob/main/Menu.png)
)](https://www.youtube.com/watch?v=8YYgRikKdEQ)

## Tela do jogador 
![image](https://github.com/Gabriel-S-E8/Projeto-Jogo/blob/main/Print%202%20.png)

## Zumbi e NPC
![image](https://github.com/Gabriel-S-E8/Projeto-Jogo/blob/main/print%201.png)

# Funcionalidades Extras

## Pular
Inicilmente o jogo não tinha a opção de pular então acabei adicionando essa funcionalidade não e bem um pulo e mais mover a posição do personagem para cima e para a posição inicial usando lerp para deixar mais suave e realmente parecer um pulo
```csharp
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
```
![Alt text](https://github.com/Gabriel-S-E8/Projeto-Jogo/blob/main/gif%20pulo.gif)
## Dash
Criei uma funcinalidade para que quando o usuario clicar com o botaão do mouse o personagem deve dar um dash modificando dentro do codigo de controle de personagem que ja existia 
```csharp
IEnumerator Dash()
{
    float dashDistance = 4; // Ajuste para a distância desejada do dash
    float dashDuration = 0.2f; // Ajuste a duração do dash conforme necessário
    Vector3 dashDirection = transform.forward * dashDistance;
    Vector3 startPosition = transform.position;
    Vector3 endPosition = startPosition + dashDirection;

    float startTime = Time.time;

    while (Time.time < startTime + dashDuration)
    {
        transform.position = Vector3.Lerp(startPosition, endPosition, (Time.time - startTime) / dashDuration);
        yield return null;
    }

    transform.position = endPosition; // Garante que o personagem chegue na posição final
}
```

