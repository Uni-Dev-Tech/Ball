using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlatform : MonoBehaviour
{
    // Переменная для регулировки скорости подъема игрока
    public float forceLifting;
    // Метод подъема игрока с заданной скоростью пока игрок находится в зоне действия
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody rblift;
            rblift = other.GetComponent<Rigidbody>();
            rblift.AddForce(Vector3.up * forceLifting * Time.deltaTime);
        }
    }
}
