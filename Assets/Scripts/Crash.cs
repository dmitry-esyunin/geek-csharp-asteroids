using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using PlayerPlane;
public class Crash : MonoBehaviour
{

    private void OnTriggerEnter(Collider  other)
    {
       
       
        if (other.gameObject.CompareTag("player"))
        {
            var player = other.GetComponent<PlayerPlane>();
            player.die();
            
        }
    }


}
