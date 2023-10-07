using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using System;

public class Timers : MonoBehaviour
{
    public float GameTime;
    public TextMeshPro TimerText;
    
    public static event Action TimerEnd;
    
    // Start is called before the first frame update
    
    void Start()
    {
        GameTime = 1200;
        TimerText.text = GameTime.ToString();
     
        StartCoroutine(updateTime());
    }

    // Update is called once per frame
    IEnumerator updateTime()
    {   
        while (GameTime > 0)
        {
            yield return new WaitForSeconds(1);
            GameTime--;
            TimerText.text = GameTime.ToString();
        }
        if (GameTime <= 0)
        {
            TimerEnd?.Invoke();
        }
    }
}
