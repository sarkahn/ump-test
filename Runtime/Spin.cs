using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField]
    float _speed = 80f;

    private void Update()
    {
        transform.RotateAround(
            transform.position, 
            Vector3.up,
            -(_speed * Time.deltaTime));
    }
}
