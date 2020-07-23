using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForTeleportChallenge : MonoBehaviour
{
    // Возвращает шарик при выпадении его за карту
    private void OnCollisionEnter(Collision collision)
    {
        TeleportForChallenge.teleportPoint = new Vector3(-41.94225f, 30.98604f, -16.82062f);
        if (collision.gameObject.CompareTag("Finish")) transform.position = TeleportForChallenge.teleportPoint;
    }
}
