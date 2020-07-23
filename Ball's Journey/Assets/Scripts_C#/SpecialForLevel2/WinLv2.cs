using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLv2 : MonoBehaviour
{
    // Переход на след лвл
    public void OnTriggerEnter(Collider other)
    {
        CheckPointScene2.playerLife = 3;
        SceneManager.LoadScene("3level");
    }
}
