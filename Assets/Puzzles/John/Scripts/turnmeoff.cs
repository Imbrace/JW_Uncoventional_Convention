using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnmeoff : MonoBehaviour
{
    public GameObject Fuse;
    void Start()
    {
        
    }

    // Update is called once per frame
   public void byebyecollision()
    {
        Fuse.GetComponent<OVRGrabbable>().enabled = false;
    }
}
