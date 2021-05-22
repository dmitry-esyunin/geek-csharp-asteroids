using UnityEngine;

public class RockSpawn : MonoBehaviour
{
    [SerializeField] private GameObject _RockPrefab;
    [SerializeField] private int _NumberOfRocks = 10;
    [SerializeField] private float _RockTimePeriodInSec = 5f;


    private void Start()
    {
        _PeriodicRockThrow();    
    }

    private void _PeriodicRockThrow()
    {
        if (_NumberOfRocks > 0 ) 
        {
            Invoke(nameof(_PeriodicRockThrow) , _RockTimePeriodInSec);
            _AddRock();
            _NumberOfRocks--;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void _AddRock()
    {
        Instantiate(_RockPrefab, transform.position, Quaternion.identity);
    }
}
