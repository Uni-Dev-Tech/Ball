using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalNextlvSound : MonoBehaviour
{
    private AudioSource portalSound;
    private void OnTriggerEnter(Collider other)
    {
        if (YellowPoint.yellowConnection == true && RedPoint.redConnection == true && GreenPoint.greenConnection == true)
        {
            portalSound = GetComponent<AudioSource>();
            portalSound.Play();
        }
    }
}
