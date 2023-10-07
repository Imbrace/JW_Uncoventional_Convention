using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
public class Droppodready : MonoBehaviour
{

    // Start is called before the first frame update
    public static event Action goodEnd;

    public bool droppodready;
   
    void Start()
    {
        droppodready = false;
        MasterJohn.JohnisDone += ready;
    }

    void ready()
    {
        droppodready = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(droppodready == true)
        {
            goodEnd?.Invoke();
        }
    }
}
