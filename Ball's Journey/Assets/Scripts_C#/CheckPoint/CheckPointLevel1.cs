using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPointLevel1 : MonoBehaviour
{
    public Vector3 start; // Стартовая позиция игрока
    public Vector3 rightCheckPoint; // Чек-поинт на правом пути
    public Vector3 leftCheckPoint; // Чек-поинт на левом пути
    public Vector3 forwardCheckPoint; // Чек-поинт впереди
    private Vector3 playerCheckPoint; // Хранения чек-поинта
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
        if (collision.gameObject.CompareTag("Respawn_R"))
        {
            playerCheckPoint = rightCheckPoint;
        }
        if (collision.gameObject.CompareTag("Respawn_L"))
        {
            playerCheckPoint = leftCheckPoint;
        }
        if (collision.gameObject.CompareTag("Respawn_F"))
        {
            playerCheckPoint = forwardCheckPoint;
        }
        if (collision.gameObject.CompareTag("Start"))
        {
            playerCheckPoint = start;
        }
        // Отбирает жизни при падении с карты, возвращает игрока в чек-поинтб либо перезагружает уровень
        if (collision.gameObject.CompareTag("Finish"))
        {
            --playerLife;
            if (playerLife == 0) SceneManager.LoadScene("1level");
            else if (playerLife > 0)
            {
                transform.position = playerCheckPoint;
            }
        }
    }
}
