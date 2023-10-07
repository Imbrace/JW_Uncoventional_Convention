using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterofPictures : MonoBehaviour
{

    public Sprite[] codeimages;
    // Update is called once per frame
    public void Indexs(int I)
    {
        GetComponent<SpriteRenderer>().sprite = codeimages[I];
    }
}
