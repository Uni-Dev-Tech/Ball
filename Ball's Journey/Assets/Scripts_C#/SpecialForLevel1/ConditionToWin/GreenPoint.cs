using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPoint : MonoBehaviour
{
    // Условие перехода на другой уровень
    static public bool greenConnection = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GreenTel")) greenConnection = true;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("GreenTel")) greenConnection = false;
    }
}
