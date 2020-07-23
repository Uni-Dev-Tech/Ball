using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLeft : MonoBehaviour
{
    public AudioSource ariveSound;
    // Идентификация объектов 
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;
    public GameObject obj5;
    // Условие их "появления" при возрате к чек-поинту
    private void OnCollisionEnter(Collision collision)
    {
        if (obj1.GetComponent<Collider>().enabled == false && obj1.GetComponent<MeshRenderer>().enabled == false) ariveSound.Play();
        obj1.GetComponent<Collider>().enabled = true;
        obj1.GetComponent<MeshRenderer>().enabled = true;

        obj2.GetComponent<Collider>().enabled = true;
        obj2.GetComponent<MeshRenderer>().enabled = true;

        obj3.GetComponent<Collider>().enabled = true;
        obj3.GetComponent<MeshRenderer>().enabled = true;

        obj4.GetComponent<Collider>().enabled = true;
        obj4.GetComponent<MeshRenderer>().enabled = true;

        obj5.GetComponent<Collider>().enabled = true;
        obj5.GetComponent<MeshRenderer>().enabled = true;
    }
}
