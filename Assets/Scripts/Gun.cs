using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    [SerializeField] private GameObject _bullerPrefab;
    [SerializeField] private float _initialForce;

   
    void Update()
    {

        if (Input.GetMouseButton(0) || Input.GetButtonDown("Fire1") )
        {
            _Shooting();
        }
        
    }

    void _Shooting()
    {
            /*var newBall = Instantiate(_bullerPrefab, transform.position, Quaternion.identity, transform);*/
            var newBall = Instantiate(_bullerPrefab, transform.position, Quaternion.Euler(0,0,0));
            var newBallBody = newBall.GetComponent<Rigidbody>();
            newBallBody.AddForce(Vector3.forward * _initialForce);
    }
}
