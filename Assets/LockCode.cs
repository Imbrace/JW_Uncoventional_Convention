using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class LockCode : MonoBehaviour


{
    public Transform wheel1;
    public Transform wheel2;
    public Transform wheel3;

    public float Code1;
    public float Code2;
    public float Code3;

    public int Code1Index;
    public int Code2Index;
    public int Code3Index;

    public GameObject Code1Image;
    public GameObject Code2Image;
    public GameObject Code3Image;

    [System.NonSerialized] public float[] codes = {80f,40f,-1.5f,320f,280f,300f,340f,20f,60f};

    public static event Action OpenDoors;

    
    // 9 = 60
    // 8 = 20
    // 7 = 340
    //6 = 300
    //5 = 280
    //4 = 320
    // 3 = -1.5
    // 2 = 40
    // 1 = 80

    private void Start()
    {
        Code1Index = UnityEngine.Random.Range(0, codes.Length);
        Code2Index = UnityEngine.Random.Range(0, codes.Length);
        Code3Index = UnityEngine.Random.Range(0, codes.Length);

        Code1 = codes[Code1Index];
        Code2 = codes[Code2Index];
        Code3 = codes[Code3Index];

        Code1Image.gameObject.GetComponent<MasterofPictures>().Indexs(Code1Index);
        Code2Image.gameObject.GetComponent<MasterofPictures>().Indexs(Code2Index);
        Code3Image.gameObject.GetComponent<MasterofPictures>().Indexs(Code3Index);
    }

    // Update is called once per frame
    //wheelcode
    private void Update()
    {
        if (wheel1.transform.rotation.eulerAngles.x >= Code1 - 5f && wheel1.transform.rotation.eulerAngles.x <= Code1 + 10f)
        {
            if (wheel2.transform.rotation.eulerAngles.x >= Code2 - 5f && wheel2.transform.rotation.eulerAngles.x <= Code2 + 10f)
            {
                if (wheel3.transform.rotation.eulerAngles.x >= Code3 - 5f && wheel3.transform.rotation.eulerAngles.x <= Code3 + 10f)
                {
                    OpenDoors?.Invoke();
                    Destroy(gameObject);
                }
           }
        }
    }
}
