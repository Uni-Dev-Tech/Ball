using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationAroundObject : MonoBehaviour
{
    public GameObject parentObject;
    public Vector3 objectCenter;
    public Vector3 direction;
    public float speed;
    public float X, Y, Z;

    private void FixedUpdate()
    {
        transform.RotateAround(objectCenter, direction, speed * Time.fixedDeltaTime);
        transform.Rotate(X * Time.fixedDeltaTime, Y * Time.fixedDeltaTime, Z * Time.fixedDeltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.transform.parent = parentObject.transform;
    }
    private void OnCollisionExit(Collision collision)
    {
        collision.gameObject.transform.parent = null;
    }
}
