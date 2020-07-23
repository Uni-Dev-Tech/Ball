using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    public float forceForwardBack; // Переменная для регулировки силы отталкивания игрока
    public float forceLeftRight; // Переменная для регулировки силы отталкивания игрока
    // Метод отталкивания игрока
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody playerRb;
            playerRb = other.GetComponent<Rigidbody>();
            playerRb.AddForce(Vector3.forward * forceForwardBack * Time.deltaTime);
            playerRb.AddForce(Vector3.right * forceLeftRight * Time.deltaTime);
        }
    }
}
