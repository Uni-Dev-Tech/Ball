using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportForPlayer : MonoBehaviour
{
    public Vector3 teleportPoint; // Координаты позиции
    // Метод перемещение игрока в заданную позицию
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody playerRb;
            playerRb = other.GetComponent<Rigidbody>();
            playerRb.transform.position = teleportPoint;
        }
    }
}
