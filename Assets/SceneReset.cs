using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReset : MonoBehaviour
{

    float startTime = 0f;
    float holdTime = 5.0f;

    public string FirstScene;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.X))
        {
            startTime = Time.time;
        }

        if (OVRInput.Get(OVRInput.RawButton.X))
        {
            if(startTime + holdTime <= Time.time);
            SceneManager.LoadScene(FirstScene, LoadSceneMode.Single);
        }
    }
}
