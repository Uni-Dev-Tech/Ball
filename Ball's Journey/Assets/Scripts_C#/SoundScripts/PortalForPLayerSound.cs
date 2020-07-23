using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalForPLayerSound : MonoBehaviour
{
    private AudioSource portalSound;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            portalSound = GetComponent<AudioSource>();
            portalSound.Play();
        }
    }
}
