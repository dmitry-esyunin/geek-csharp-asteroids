using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMove : MonoBehaviour
{
    [SerializeField] private float _speed = 1f; // Скорость движения, а в дальнейшем ускорение
    void Update()
    {
        transform.Translate(Vector3.back *  _speed * Time.deltaTime);
    }
}
