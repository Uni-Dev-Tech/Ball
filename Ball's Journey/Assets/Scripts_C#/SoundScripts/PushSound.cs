using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushSound : MonoBehaviour
{
    private AudioSource pushSound;
    private void OnTriggerEnter(Collider other)
    {
        pushSound = GetComponent<AudioSource>();
        pushSound.Play();
    }
}
