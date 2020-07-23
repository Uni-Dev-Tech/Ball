using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftPlatform : MonoBehaviour
{
    public GameObject platform; // Идентификация платформы, которая будет поднимать игрока
    public float demandForce; // Переменная для регулировки скорости подъема 
    public Vector3 finalPosition; // Переменная для ограничения подъема платформы
    public Transform lift; // Положение платформы 
    // Метод подъема платформы
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           Rigidbody platformRb;
           platformRb = platform.GetComponent<Rigidbody>();
           if (lift.position.y < finalPosition.y)
           {
                platformRb.AddForce(Vector3.up * demandForce * Time.deltaTime);
           }
        }
    }
    // Методы "Родители-дети" платформы и игрока
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.transform.parent = null;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.transform.parent = platform.gameObject.transform;
        }
    }
}
