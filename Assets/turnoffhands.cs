using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
public class turnoffhands : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LockCode.OpenDoors += byebyehands;
    }

    void byebyehands()
    {
        gameObject.GetComponent<Collider>().enabled = false;
    }
    
}
