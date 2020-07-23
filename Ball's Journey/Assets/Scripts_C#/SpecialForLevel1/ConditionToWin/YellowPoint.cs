using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPoint : MonoBehaviour
{
    // Условие перехода на другой уровень
    static public bool yellowConnection = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("YellowTel")) yellowConnection = true;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("YellowTel")) yellowConnection = false;
    }
}
