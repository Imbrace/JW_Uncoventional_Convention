using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    // Start is called before the first frame update

    public string FirstScene; 

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.X))   
        {
            SceneManager.LoadScene(FirstScene, LoadSceneMode.Single);
            Debug.Log("Reset");
        }
    }
}
