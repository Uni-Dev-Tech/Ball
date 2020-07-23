using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTime : MonoBehaviour
{
    public AudioSource desSound;
    public GameObject platform; // Идентификация объекта
    // // Исчезновение объекта после окончание времени
    public void DestoyObj()
    {
        platform.GetComponent<Collider>().enabled = false;
        platform.GetComponent<MeshRenderer>().enabled = false;
    }
    // Задержка времени
    private void OnCollisionEnter(Collision collision)
    {
        Invoke("DesSound", 2.9f);
        Invoke("DestoyObj", 3);
    }
    public void DesSound()
    {
        desSound.Play();
    }
}
