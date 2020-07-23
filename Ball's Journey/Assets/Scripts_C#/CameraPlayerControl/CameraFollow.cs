using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform objToFollow; // Идентификация позиции объекта преследования
    private float X, Y, Z; // Переменные принимающие значения при повороте мыши
    public float sensitive; // Переменная задающая чувствительность мыши
    public float sensitiveScroll; // Переменная задущая чувствительность "скролинга"
    // Метод регулировки камеры относительно объекта преследования
    void FixedUpdate()
    {
        Transform cameraTr;
        cameraTr = GetComponent<Transform>();

        if (Input.GetKey(KeyCode.Mouse1)) X = Input.GetAxis("Mouse X");
        else if (Input.GetKey(KeyCode.Mouse0)) Y = Input.GetAxis("Mouse Y");
        Z = Input.GetAxis("Mouse ScrollWheel");

        cameraTr.Translate(X * sensitive * Time.fixedDeltaTime, Y * sensitive * Time.fixedDeltaTime, Z * sensitiveScroll * Time.fixedDeltaTime);
        cameraTr.LookAt(objToFollow);
    }
}
