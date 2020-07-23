using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLv3 : MonoBehaviour
{
    // Переход на след лвл
    public void OnTriggerEnter(Collider other)
    {
        CheckPointScene3.playerLife = 3;
        SceneManager.LoadScene("1level");
    }
}
