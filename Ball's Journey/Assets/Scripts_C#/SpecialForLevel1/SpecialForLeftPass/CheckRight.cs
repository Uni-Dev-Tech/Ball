using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckRight : MonoBehaviour
{
    public AudioSource ariveSound;
    // Идентификация объектов 
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    public GameObject obj6;
    // Условие их "появления" при возрате к чек-поинту
    private void OnCollisionEnter(Collision collision)
    {
        if (obj1.activeInHierarchy == false) ariveSound.Play();
        obj1.SetActive(true);

        obj2.SetActive(true);

        obj3.SetActive(true);

        obj4.SetActive(true);

        obj5.SetActive(true);

        obj6.SetActive(true);
    }
}
