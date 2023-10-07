using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSymbolLocation : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject[] spawnPoints;
    GameObject currentPoint;
    int index;

    void Start()
    {
            spawnPoints = GameObject.FindGameObjectsWithTag("Symbol");
            index = Random.Range(0, spawnPoints.Length);
            currentPoint = spawnPoints[index];
            transform.position = currentPoint.gameObject.transform  .position;

    }

}

