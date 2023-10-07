using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using TMPro;

public class Collectablehands : MonoBehaviour
{
    // Start is called before the first frame update

    public static event Action enoughitems;
    public int items;
    public TextMeshPro handText;
    void Start()
    {
        items = 5;
        ObjectCollect.gotItem += updateHandCount;
        handText.text = items.ToString();
    }

  public void updateHandCount()
    {
        items--;
        handText.text = items.ToString();
        if (items == 0)
        {
            enoughitems?.Invoke();
        }
    }
}

