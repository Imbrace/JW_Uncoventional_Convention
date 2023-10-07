using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBatteryLocation : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject[] spawnPoints;
    GameObject currentPoint;
    int index;

    void Start()
    {
            spawnPoints = GameObject.FindGameObjectsWithTag("Point");
            index = Random.Range(0, spawnPoints.Length);
            currentPoint = spawnPoints[index];
            transform.position = currentPoint.gameObject.transform.position;

    }

}

