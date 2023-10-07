using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
public class BulbObjectSnap : MonoBehaviour
{
    public Vector3 bulbpos;
    public Quaternion bulbrot;
    public string correctname;
    public GameObject[] gameObjects;
    public string lights;
    bool trigged;
    public static event Action bulbplus;

    void Start()
    {
        gameObjects = GameObject.FindGameObjectsWithTag(lights);
    }

    void OnTriggerEnter(Collider collision)
    {
            if (collision.gameObject.name == correctname)
            {
                if (trigged == false)
                {
                bulbplus?.Invoke();
                trigged = true;
                }

                //GameObject.Find(correctname).GetComponent<CapsuleCollider>().enabled = false;
                    GameObject.Find(correctname).GetComponent<Rigidbody>().isKinematic = true;
                    GameObject.Find(correctname).transform.rotation = bulbrot;
                    GameObject.Find(correctname).transform.position = bulbpos;
                     GameObject.Find(correctname).GetComponent<turnmeoff>().byebyecollision();
           
           

            gameObject.GetComponent<Collider>().enabled = false;
             }
        }
    }

