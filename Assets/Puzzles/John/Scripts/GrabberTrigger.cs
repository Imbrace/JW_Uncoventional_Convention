using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabberTrigger : MonoBehaviour
{ /*
    public float R;
    public float B;
    public float G;
    */

    public Material on;
    public Material off;


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "handcol")
        {
            this.GetComponent<MeshRenderer>().material = on;
        }
    }

    void OnTriggerExit(Collider col)
    {
        this.GetComponent<MeshRenderer>().material = off;
    }
}
