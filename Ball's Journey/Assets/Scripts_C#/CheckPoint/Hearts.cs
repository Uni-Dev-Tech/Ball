using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearts : MonoBehaviour
{
    public GameObject heart2;
    public GameObject heart3;
    private GameObject[] hearts;
    private void Start()
    {
        hearts = new GameObject[2];
        hearts[0] = heart2;
        hearts[1] = heart3;
    }
    private void Update()
    {
        if (CheckPointLevel1.playerLife == 2) Destroy(hearts[1]);
        if(CheckPointLevel1.playerLife == 1) Destroy(hearts[0]);

        if (CheckPointScene2.playerLife == 2) Destroy(hearts[1]);
        if (CheckPointScene2.playerLife == 1) Destroy(hearts[0]);

        if (CheckPointScene3.playerLife == 2) Destroy(hearts[1]);
        if(CheckPointScene3.playerLife == 1) Destroy(hearts[0]);
    }

}
