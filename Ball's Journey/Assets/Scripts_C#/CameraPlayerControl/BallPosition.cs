using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPosition : MonoBehaviour
{
    public Transform compareObject;
    private Vector3 differencePos;
    private Vector3 firstDif;
    public static bool IsMoving = false;

    private void Start()
    {
        firstDif = compareObject.position - transform.position;
    }
    private void Update()
    {
        differencePos = compareObject.position - transform.position;
        if (firstDif == differencePos) IsMoving = false;
        if(firstDif != differencePos)
        {
            firstDif = differencePos;
            IsMoving = true;
        }
    }
}
