using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterLeave : MonoBehaviour
{
    // Исчезновение объекта после прекращения касания с ним
    private void OnCollisionExit(Collision collision)
    {
        gameObject.SetActive(false);
    }
}
