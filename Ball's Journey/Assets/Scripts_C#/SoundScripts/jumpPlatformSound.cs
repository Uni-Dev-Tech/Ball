using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpPlatformSound : MonoBehaviour
{
    private AudioSource upSound;
    private void OnTriggerEnter(Collider other)
    {
        upSound = GetComponent<AudioSource>();
        upSound.Play();
    }
    private void OnTriggerExit(Collider other)
    {
        upSound.Stop();
    }
}
