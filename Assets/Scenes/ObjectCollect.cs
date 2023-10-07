using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using Unity.VisualScripting;

public class ObjectCollect : MonoBehaviour
{
    // Start is called before the first frame update
    public static event Action gotItem;
    public GameObject Crate;
  
    private void OnTriggerEnter(Collider other)
    {

       
        if( other.gameObject.tag == "handcol")
        {
            
            gotItem?.Invoke();
            GameObject.Destroy(Crate);
        }
    }
}
