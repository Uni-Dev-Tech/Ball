using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesAfLvSound : MonoBehaviour
{
    public AudioSource desSound;
    private void OnCollisionExit(Collision collision)
    {
        desSound.Play();
    }
}
