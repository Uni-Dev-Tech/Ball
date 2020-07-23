using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liftPlatformSound : MonoBehaviour
{
    private AudioSource moveUp;
    public AudioSource moveDown;
    private void OnTriggerEnter(Collider other)
    {
        moveUp = GetComponent<AudioSource>();
        moveDown.Stop();
        moveUp.Play();
    }
    private void OnTriggerExit(Collider other)
    {
        moveUp.Stop();
        moveDown.Play();
    }
}
