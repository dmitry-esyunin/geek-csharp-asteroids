using UnityEngine;

public class PlayerPlane : MonoBehaviour
{
    
    private bool _isFinish = false;
    
    void Update()
    {
        if (_isFinish)
        {
            if (Input.GetKey("escape"))  Application.Quit();        
        }
    }


    public void die()
    {
        Destroy(gameObject);
        _isFinish =true;
        
    }

}
