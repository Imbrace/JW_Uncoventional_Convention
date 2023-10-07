using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;


public class DoorsOpenEk : MonoBehaviour
{
    // Start is called before the first frame update

    //Fetch the Animator
    Animator m_Animator;
    AudioSource audioSource;

    void Start()
    {
        LockCode.OpenDoors += OpenZEEDoors;
        m_Animator = gameObject.GetComponent<Animator>();   
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OpenZEEDoors()
    {
        m_Animator.SetBool("Complete", true);
        audioSource.Play();
        LockCode.OpenDoors -= OpenZEEDoors;
    }
}
