using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportForChallenge : MonoBehaviour
{
    // Позиции для появления шариков
    public static Vector3 teleportPoint; // Переменная для CheckForTeleportChallenge
    public Vector3 teleportPoint_1;
    public Vector3 teleportPoint_2;
    public Vector3 teleportPoint_3;
    public Vector3 teleportPoint_4;
    public Vector3 teleportPoint_5;
    public Vector3 teleportPoint_6;
    public Vector3 teleportPoint_7;
    public Vector3 teleportPoint_8;
    public Vector3 teleportPoint_9;
    private byte position = 1; // Счетчик позиций
    // Изменение позиции шариков 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
        {
            Rigidbody playerRb;
            playerRb = other.GetComponent<Rigidbody>();
            switch(position)
            {
                case 1:
                    playerRb.transform.position = teleportPoint_1;
                    position++;
                    break;
                case 2:
                    playerRb.transform.position = teleportPoint_2;
                    position++;
                    break;
                case 3:
                    playerRb.transform.position = teleportPoint_3;
                    position++;
                    break;
                case 4:
                    playerRb.transform.position = teleportPoint_4;
                    position++;
                    break;
                case 5:
                    playerRb.transform.position = teleportPoint_5;
                    position++;
                    break;
                case 6:
                    playerRb.transform.position = teleportPoint_6;
                    position++;
                    break;
                case 7:
                    playerRb.transform.position = teleportPoint_7;
                    position++;
                    break;
                case 8:
                    playerRb.transform.position = teleportPoint_8;
                    position++;
                    break;
                case 9:
                    playerRb.transform.position = teleportPoint_9;
                    position -= 8;
                    break;
            }
        }
    }
}
