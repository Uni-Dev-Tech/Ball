using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject cameraPosition; // Идентификация камеры
    public Rigidbody rb; // Физика шарика
    public float force; // Скорость передвижения
    public float jumpForce; // Высота прыжка
    private bool jumpPosibility = true; // Ограничение количества возможных прыжков

    private Vector3 VectorW, VectorS, VectorD, VectorA, VectorUp;
    private bool jump = false;
    private bool pressW = false;
    private bool pressS = false;
    private bool pressA = false;
    private bool pressD = false;

    // Метод управление шариком
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            VectorW = cameraPosition.transform.forward * force;
            pressW = true;
        }
        if (!Input.GetKey(KeyCode.W)) pressW = false;

        if (Input.GetKey(KeyCode.S))
        {
            VectorS = cameraPosition.transform.forward * -force;
            pressS = true;
        }
        if (!Input.GetKey(KeyCode.S)) pressS = false;

        if (Input.GetKey(KeyCode.A))
        {
            VectorA = cameraPosition.transform.right * -force;
            pressA = true;
        }
        if (!Input.GetKey(KeyCode.A)) pressA = false;

        if (Input.GetKey(KeyCode.D))
        {
            VectorD = cameraPosition.transform.right * force;
            pressD = true;
        }
        if (!Input.GetKey(KeyCode.D)) pressD = false;

        if (Input.GetKeyDown(KeyCode.Space) && jumpPosibility == true)
        {
            VectorUp = Vector3.up * jumpForce;
            jump = true;
        }
    }
    private void FixedUpdate()
    {
        if (pressW == true) rb.AddForce(VectorW * Time.fixedDeltaTime);
        if (pressS == true) rb.AddForce(VectorS * Time.fixedDeltaTime);
        if (pressD == true) rb.AddForce(VectorD * Time.fixedDeltaTime);
        if (pressA == true) rb.AddForce(VectorA * Time.fixedDeltaTime);
        if (jump == true)
        {
            rb.AddForce(VectorUp * Time.fixedDeltaTime);
            jumpPosibility = false;
            jump = false;
        }
    }
    // Метод контроля количества прыжков
    private void OnCollisionEnter(Collision collision)
    {
        jumpPosibility = true;
    }
}
