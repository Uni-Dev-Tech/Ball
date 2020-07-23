using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPoint : MonoBehaviour
{
    // Условие перехода на другой уровень
    static public bool redConnection = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RedTel")) redConnection = true;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("RedTel")) redConnection = false;
    }
}
