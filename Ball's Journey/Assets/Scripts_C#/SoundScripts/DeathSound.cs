using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSound : MonoBehaviour
{
    private AudioSource hit;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("RedTel") ||
            collision.gameObject.CompareTag("GreenTel") || collision.gameObject.CompareTag("YellowTel"))
        {
            hit = GetComponent<AudioSource>();
            hit.Play();
        }
    }
}
