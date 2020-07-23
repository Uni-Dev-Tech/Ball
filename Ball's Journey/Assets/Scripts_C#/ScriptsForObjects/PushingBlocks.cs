using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushingBlocks : MonoBehaviour
{
    public float x, y, z;
    public float maxX, minX;
    public float maxY, minY;
    public float maxZ, minZ;
    private AudioSource pushSound;
    private void Start()
    {
        pushSound = GetComponent<AudioSource>();
    }
    private void FixedUpdate()
    {
        gameObject.transform.Translate(x * Time.fixedDeltaTime, y * Time.fixedDeltaTime, z * Time.fixedDeltaTime);

        if (gameObject.transform.position.x >= maxX || gameObject.transform.position.x <= minX)
        {
            x *= -1;
        }
        if (gameObject.transform.position.y >= maxY || gameObject.transform.position.y <= minY)
        {
            y *= -1;
        }
        if (gameObject.transform.position.z >= maxZ || gameObject.transform.position.z <= minZ)
        {
            pushSound.Play();
            z *= -1;
        }
    }
}
