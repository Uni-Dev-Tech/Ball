using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour
{
    public float force; // Переменная регулировки скорости передвижения платформы
    public GameObject movingPlatform; // Идентификация платформы
    public float minPosition; // Переменная ограничения передвижения платформы(мин.)
    public float maxPosition; // Переменная ограничения передвижения платфромы(макс.)
    // Метод передвижения платформы с ограничениями
    private void FixedUpdate()
    {
        Rigidbody moving;
        moving = movingPlatform.GetComponent<Rigidbody>();
        if (movingPlatform.transform.position.x < minPosition) moving.AddForce(Vector3.right * force * Time.fixedDeltaTime);
        else if (movingPlatform.transform.position.x > maxPosition) moving.AddForce(Vector3.right * -force * Time.fixedDeltaTime);
    }
    // Метод "Родители-дети" платформы и игрока
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.transform.parent = movingPlatform.gameObject.transform;
    }
    private void OnTriggerExit(Collider other)
    {
        other.gameObject.transform.parent = null;
    }
}
