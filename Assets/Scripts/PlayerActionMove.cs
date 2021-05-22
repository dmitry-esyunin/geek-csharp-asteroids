using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerActionMove : MonoBehaviour
{
    [SerializeField] private float _speed; // Скорость движения, а в дальнейшем ускорение
    
    [SerializeField] private float _leftBorder = -1; 
    [SerializeField] private float _rightBorder = 1; 
    [SerializeField] private float _forwardBorder = 10; 
    [SerializeField] private float _backBorder = 0; 

    private Vector3 _direction = Vector3.forward;
    private void Update()
    {
        

        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");       
        

        transform.Translate(_direction * _speed * Time.deltaTime);

        if (transform.position.x > _rightBorder)  {
            transform.position =  new Vector3(_rightBorder, transform.position.y,transform.position.z); 
        }
        if (transform.position.x < _leftBorder )  {
            transform.position =  new Vector3(_leftBorder, transform.position.y,transform.position.z); 
        }
        if (transform.position.z > _forwardBorder )  {
            transform.position =  new Vector3(transform.position.x, transform.position.y, _forwardBorder); 
        }
        if (transform.position.z < _backBorder )  {
            transform.position =  new Vector3(transform.position.x, transform.position.y, _backBorder); 
        }
        
        print("direction:"+ _direction  + "   position:" + transform.position);
        
    }

}
