using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueLightMovement : MonoBehaviour
{
    public Light blueLight;
    public float moveDistance = 5f;
    public float moveSpeed = 2f;

    private Vector3 startPos;
    private float moveTimer;

    private void Start()
    {
        startPos = blueLight.transform.position;
    }

    private void Update()
    {
        MoveBlueLight();
    }

    private void MoveBlueLight()
    {
        moveTimer += Time.deltaTime * moveSpeed;

        float xPos = Mathf.Sin(moveTimer) * moveDistance;
        Vector3 newPosition = startPos + new Vector3(xPos, 0f, 0f);
        blueLight.transform.position = newPosition;
    }
}