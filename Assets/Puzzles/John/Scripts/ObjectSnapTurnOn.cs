using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
public class ObjectSnapTurnOn : MonoBehaviour
{
    public Vector3 fusepos;
    public string correctname;
    public Quaternion fuserot;
    public GameObject[] gameObjects;
    public string lights;
    bool trigged;
    public static event Action batteryplus;
    void Start()
    {
        trigged = false;
        gameObjects = GameObject.FindGameObjectsWithTag(lights);

        foreach (GameObject ob in gameObjects)
        {
            ob.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.name == correctname)
        {
            if (trigged == false)
            {
                batteryplus?.Invoke();
                trigged = true;
            }

            GameObject.Find(correctname).GetComponent<Rigidbody>().isKinematic = true;
            GameObject.Find(correctname).transform.position = fusepos;
            GameObject.Find(correctname).transform.rotation = fuserot;
            GameObject.Find(correctname).GetComponent<turnmeoff>().byebyecollision();

            foreach (GameObject ob in gameObjects)
            {
                ob.SetActive(true);
            }
            
            gameObject.GetComponent<Collider>().enabled = false;
          
        }
    }
}
   

