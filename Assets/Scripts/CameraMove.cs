using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private GameObject _player;
    private Vector3 offset;
 
    private void Start()
    {
       
        _player = GameObject.FindWithTag("player"); 
        offset = transform.position - _player.transform.position;
    }
 
    private void LateUpdate()
    {
        if (_player) {
            transform.position = Vector3.Lerp(transform.position, _player.transform.position + offset, 10f * Time.deltaTime);
        }
    }
}
