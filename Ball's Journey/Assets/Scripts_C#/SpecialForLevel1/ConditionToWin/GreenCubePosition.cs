using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCubePosition : MonoBehaviour
{
    public Vector3 startCubePosition; // Позиция кубика по-умолчанию
    public Vector3 positionAfterTeleport; // Позиция кубика после прохождение телепорта
    static public Vector3 greenCubePosition; // Позиция для переноса кубика при выпадании его за пределы карты
    // Хранение позиции кубика
    private void Start()
    {
        greenCubePosition = startCubePosition;
    }
    // Чек-поинты кубика
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Start"))
        {
            greenCubePosition = positionAfterTeleport;
        }
        if(collision.gameObject.CompareTag("Finish"))
        {
            transform.position = greenCubePosition;
        }
    }
}
