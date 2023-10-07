using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
public class OpenMazeDoors : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Door;
    void Start()
    {
        Collectablehands.enoughitems += themazeisfree;
    }

    // Update is called once per frame
    void themazeisfree()
    {
        GameObject.Destroy(Door);
    }
}
