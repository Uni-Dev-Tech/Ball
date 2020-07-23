using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalForObjectSound : MonoBehaviour
{
    private AudioSource portalSound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("YellowTel") || other.CompareTag("GreenTel") || other.CompareTag("RedTel"))
        {
            portalSound = GetComponent<AudioSource>();
            portalSound.Play();
        }
    }
}
