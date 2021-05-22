using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{


    [SerializeField] private float  _lifetimeInSec = 2f;
    [SerializeField] private float  _lifetimeAfterCollisionInSec = 1f;
    [SerializeField] private int  _damage = 100;

    private bool _isAlreadyCollided =false;

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(SelfDestroy) , _lifetimeInSec);
    }

    private void SelfDestroy()
    {
         Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider  other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            var enemy = other.GetComponent<MyEnemy>();
            enemy.Hurt(_damage);            
            CancelInvoke();
            Destroy(gameObject);
        }
    }


    private void OnCollisionEnter(Collision other) {
        if (_isAlreadyCollided) return;
        _isAlreadyCollided =true;
        Invoke(nameof(SelfDestroy) , _lifetimeAfterCollisionInSec);
    }
}
