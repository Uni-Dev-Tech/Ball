using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{
    public Transform objToFollow; // Идентификация положения объекта преследования
    private Vector3 deltaPos; // Координаты для хранения разницы позиций преследователя и объекта преследования
    // Метод выявления разницы позиций
    void Start()
    {
        deltaPos = transform.position - objToFollow.position;
    }
    // Метод преследования
    void Update()
    {
        transform.position = objToFollow.position + deltaPos;
    }

}
