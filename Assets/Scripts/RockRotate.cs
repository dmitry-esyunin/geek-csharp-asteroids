
using UnityEngine;
public class RockRotate : MonoBehaviour
{
    [SerializeField] private float _rotospeedX = 100f; // Скорости вращения по осям
    [SerializeField] private float _rotospeedY = 0f; 
    [SerializeField] private float _rotospeedZ = 100f; 

    private void Start() {
        _rotospeedX *= (2 * Random.value - 1); // -1 ... 1
        _rotospeedY *= (2 * Random.value - 1);
        _rotospeedZ *= (2 * Random.value - 1);
    }

    private void Update() {
        transform.Rotate(new Vector3(_rotospeedX, _rotospeedY, _rotospeedZ) * Time.deltaTime);
    }    
}
