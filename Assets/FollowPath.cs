using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class followPath : MonoBehaviour
{
[SerializeField] public Transform[] allwayPoints;
[SerializeField] public float rotationSpeed = 0.5f;
[SerializeField] public float movementSpeed = 0.5f;
[SerializeField] public int currentTarget;
// Start is called before the first frame update
void Start()
{
}
// Update is called once per frame
void Update()
{
Movement();
Rotate();
ChangeTarget();
}
void Movement()
{
transform.position = Vector3.MoveTowards(
transform.position,
allwayPoints[currentTarget].position,
movementSpeed * Time.deltaTime);
}
void Rotate()
{
transform.rotation = Quaternion.Slerp(transform.rotation,
Quaternion.LookRotation(
allwayPoints[currentTarget].position-transform.position),
rotationSpeed*Time.deltaTime);
}
void ChangeTarget()
{
if (transform.position == allwayPoints[currentTarget].position)
{
currentTarget++;
currentTarget = currentTarget % allwayPoints.Length;
}
}
}
