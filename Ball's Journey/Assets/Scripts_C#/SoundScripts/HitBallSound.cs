using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBallSound : MonoBehaviour
{
    private AudioSource hit;

    private void OnCollisionEnter(Collision collision)
    {
        if(!collision.gameObject.CompareTag("NotSound"))
        {
            hit = GetComponent<AudioSource>();
            hit.Play();
        }
    }
}
