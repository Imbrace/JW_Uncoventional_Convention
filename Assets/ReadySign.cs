using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
public class ReadySign : MonoBehaviour
{
    // Start is called before the first frame update

   public Light lt2;
   public Light lt1;
    public GameObject s1;
    public GameObject s2;
    void Start()
    {
        s1.SetActive(false);
        s2.SetActive(false);
        MasterJohn.JohnisDone += signson;
    }

    
    void signson()
    {
        Debug.Log("msg recieved");
        s1.SetActive(true);
        s2.SetActive(true);
    lt1.color = Color.green;
        lt2.color = Color.green;
    }
}
