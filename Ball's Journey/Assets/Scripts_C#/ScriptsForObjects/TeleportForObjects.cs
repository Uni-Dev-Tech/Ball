using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportForObjects : MonoBehaviour
{
    public Vector3 teleportPoint; // Координаты позиции 
    // Метод перемещения объекта в заданную позицию (не перемещает игрока)
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
        {
            Rigidbody playerRb;
            playerRb = other.GetComponent<Rigidbody>();
            playerRb.transform.position = teleportPoint;
        }
    }
}
