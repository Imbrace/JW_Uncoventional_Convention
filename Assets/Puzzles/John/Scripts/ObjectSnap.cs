using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
public class ObjectSnap : MonoBehaviour
{
   public Vector3 fusepos;
   public string correctname;
   public Quaternion fuserot;
   public GameObject[] gameObjects;
   public string lights;

    GameObject colfuse;

    public static event Action partsplus;
    bool trigged;
    void Start()
    {
        gameObjects = GameObject.FindGameObjectsWithTag(lights);
    }

    void OnTriggerEnter(Collider collision)
    {
        
            colfuse = collision.gameObject;

            if (collision.gameObject.name == correctname)
            {
                if (trigged == false)
                {
                      partsplus?.Invoke();
                    trigged = true;
                   }

            colfuse.GetComponent<Rigidbody>().isKinematic = true;
                colfuse.transform.rotation = fuserot;
                colfuse.transform.position = fusepos;
                GameObject.Find(correctname).GetComponent<turnmeoff>().byebyecollision();
                
               
              

                foreach (GameObject ob in gameObjects)
                {
                    ob.SetActive(false);
                }
                
            }
        
    }
}
   

