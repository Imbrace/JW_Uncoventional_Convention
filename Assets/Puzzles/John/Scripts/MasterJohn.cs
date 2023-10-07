using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
public class MasterJohn : MonoBehaviour
{

    public int parts;
    public static event Action JohnisDone;
    // Start is called before the first frame update
    void Start()
    {
        parts = 0;
        ObjectSnap.partsplus += updateparts;
        ObjectSnapTurnOn.batteryplus += updateparts;
        BulbObjectSnap.bulbplus += updateparts;
    }

    void checkparts()
    {
        if(parts >= 6)
        {
            JohnisDone?.Invoke();
            Debug.Log("invoked");
        }
    }

    void updateparts()
    {
        parts++;
        checkparts();
    }

   
}
