using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlat : MonoBehaviour
{
    public float x, y, z;
    public float limitXMax, limitXMin;
    public float limitYMax, limitYMin;
    public float limitZMax, limitZMin;
    private void FixedUpdate()
    {
        transform.Translate(x * Time.fixedDeltaTime, y * Time.fixedDeltaTime, z * Time.fixedDeltaTime);
        if (transform.position.x >= limitXMax) x *= -1;
        if (transform.position.x <= limitXMin) x *= -1;

        if (transform.position.y >= limitYMax) y *= -1;
        if (transform.position.y <= limitYMin) y *= -1;

        if (transform.position.z >= limitZMax) z *= -1;
        if (transform.position.z <= limitZMin) z *= -1;
    }
}
