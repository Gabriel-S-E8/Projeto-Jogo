using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Carro : MonoBehaviour
{
[SerializeField] WheelCollider RodaTraseiraEsquerda;
[SerializeField] WheelCollider RodaFrenteEsquerda;
[SerializeField] WheelCollider RodaFrenteDireita;
[SerializeField] WheelCollider RodaTraseiraDireita;


public float aceleracao = 500f;
public float freio = 300f;
public float anguloTorque = 15f;
private float aceleracaoAtual = 0f;
private float freioAtual = 0f;
private float anguloTorqueAtual = 0f;
private void FixedUpdate()
{
aceleracaoAtual = aceleracao * Input.GetAxis("Vertical");
RodaFrenteDireita.motorTorque = aceleracaoAtual;
RodaFrenteEsquerda.motorTorque = aceleracaoAtual;
anguloTorqueAtual = anguloTorque * Input.GetAxis("Horizontal");
RodaFrenteDireita.steerAngle = anguloTorqueAtual;
RodaFrenteEsquerda.steerAngle = anguloTorqueAtual;
if (Input.GetKey(KeyCode.Space))
{
freioAtual = freio;
}
else
{
freioAtual = 0f;
}
RodaFrenteDireita.brakeTorque = freioAtual;
RodaFrenteEsquerda.brakeTorque = freioAtual;
RodaTraseiraDireita.brakeTorque = freioAtual;
RodaTraseiraEsquerda.brakeTorque = freioAtual;
}
}