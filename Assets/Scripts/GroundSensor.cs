using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSensor : MonoBehaviour
{

    public bool _isGrounded;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 6)
            {
                _isGrounded = true;
            }
       
    }

 void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.layer == 3)
            {
                _isGrounded = true;
            }    
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.layer == 3)
            {
                _isGrounded = false;
            }    
    }
}
