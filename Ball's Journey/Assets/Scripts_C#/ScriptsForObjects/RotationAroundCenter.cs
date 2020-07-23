using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAroundCenter : MonoBehaviour
{
    public float rotationSpeed; // Переменная определяющая скорость вращения объекта 
    public GameObject CenterOfRotationPart; // Идентификация объекта
    // Метод добавление крутящего момента объекту вокруг своего центра масс
    void FixedUpdate()
    {
        Rigidbody center;
        center = CenterOfRotationPart.GetComponent<Rigidbody>();
        center.AddTorque(0, rotationSpeed * Time.fixedDeltaTime, 0);
    }
}
