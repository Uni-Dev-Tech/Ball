using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConditionForWin : MonoBehaviour
{
    private bool active = false;
    // Условие "включающее" переход на второй уровень
    private void FixedUpdate()
    {
        if (YellowPoint.yellowConnection == true && RedPoint.redConnection == true && GreenPoint.greenConnection == true)
        {
            active = true;
        }
        else active = false;
    }
    // Переход на следующий уровень 
    public void OnTriggerEnter(Collider other)
    {
        CheckPointLevel1.playerLife = 3; // Убирает баг с сердечками на втором уровне
        if (active == true)
        {
            SceneManager.LoadScene("2level");
        }
    }
}
