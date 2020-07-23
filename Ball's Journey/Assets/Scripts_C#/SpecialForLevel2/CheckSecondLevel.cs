using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSecondLevel : MonoBehaviour
{
    // Идентификация объектов 
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    public GameObject obj6;
    public GameObject obj7;
    public GameObject obj8;
    public GameObject obj9;
    public GameObject obj10;
    // Условие их "появления" при возрате к чек-поинту
    private void OnCollisionEnter(Collision collision)
    {
        obj1.SetActive(true);

        obj2.SetActive(true);

        obj3.SetActive(true);

        obj4.SetActive(true);

        obj5.SetActive(true);

        obj6.SetActive(true);

        obj7.SetActive(true);

        obj8.SetActive(true);

        obj9.SetActive(true);

        obj10.SetActive(true);
    }
}
