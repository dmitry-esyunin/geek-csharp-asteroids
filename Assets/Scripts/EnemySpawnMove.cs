using UnityEngine;

public class EnemySpawnMove : MonoBehaviour
{
 
    [SerializeField] private float _speed=1; 
    [SerializeField] private float _maxleftBorder = -1; 
    [SerializeField] private float _maxrightBorder= 1; 

    private Vector3 _direction = Vector3.right;
    private float _leftBorder = 0;
    private float _rightBorder = 0;
    private void FixedUpdate()
    {        
      transform.Translate(_direction * _speed * Time.deltaTime);
      if (transform.position.x > _rightBorder  || transform.position.x < _leftBorder  )  
      {
        _rightBorder = _maxrightBorder * Random.value;
        _leftBorder = _maxleftBorder * Random.value;
        if (_rightBorder < _leftBorder) {_leftBorder = _maxleftBorder; _rightBorder = _maxrightBorder;}
        _speed = - _speed;
      }
    }

}
