using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelMove : MonoBehaviour
{
    public GameObject wheel;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "handcol")
        {
            wheel.transform.Rotate(40, 0, 0);
        }
    }
}
