﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPointScene2 : MonoBehaviour
{
    public Vector3 start; // Стартовая позиция игрока
    public Vector3 firstCheckPoint; // Первый чек-поинт
    public Vector3 secondCheckPoint; // Второй чек-поинт
    private Vector3 playerCheckPoint; // Чранение чек-поинта
    static public byte playerLife; // Количество оставшихся жизней героя
    // Задает первый чек-поинт и количество жизней
    private void Start()
    {
        playerLife = 3;
        playerCheckPoint = start;
    }
    // Изменяет чек-поинт игрока
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Respawn"))
        {
            playerCheckPoint = firstCheckPoint;
        }
        if(collision.gameObject.CompareTag("Respawn_2"))
        {
            playerCheckPoint = secondCheckPoint;
        }
        // Отбирает жизни при падении с карты, возвращает игрока в чек-поинтб либо перезагружает уровень
        if (collision.gameObject.CompareTag("Finish"))
        {
            --playerLife;
            if (playerLife == 0) SceneManager.LoadScene("2level");
            else if (playerLife > 0)transform.position = playerCheckPoint;
        }
    }
}
