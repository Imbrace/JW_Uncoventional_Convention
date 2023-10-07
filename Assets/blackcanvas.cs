using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using UnityEngine.SceneManagement;
public class blackcanvas : MonoBehaviour
{
    // Start is called before the first frame update

   public GameObject badCam;
    public GameObject playerCam;
    public GameObject goodCam;
    public GameObject pod;
    public GameObject hole;

    void Start()
    {
        Droppodready.goodEnd += goodending;
        Timers.TimerEnd += badending;
        
       goodCam.SetActive(false);
       badCam.SetActive(false);
    }


    IEnumerator GoodEnd()
    {
        GetComponent<Animator>().SetBool("Blackscreen", true);
        yield return new WaitForSeconds(3f);
        goodCam.SetActive(true);
        playerCam.SetActive(false);
        GetComponent<Animator>().SetBool("Blackscreen", false);
        yield return new WaitForSeconds(2f);
        pod.GetComponent<Animation>().Play();
        yield return new WaitForSeconds(2f);
        GetComponent<Animator>().SetBool("Blackscreen", true);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Maze", LoadSceneMode.Single);
    }

    IEnumerator BadEnd()
    {
        GetComponent<Animator>().SetBool("Blackscreen", true);
        yield return new WaitForSeconds(3f);
        badCam.SetActive(true);
        playerCam.SetActive(false);
        GetComponent<Animator>().SetBool("Blackscreen", false);
        yield return new WaitForSeconds(2f);
        hole.GetComponent<Animation>().Play();
        yield return new WaitForSeconds(2f);
        GetComponent<Animator>().SetBool("Blackscreen", true);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    void goodending()
    {
        StartCoroutine(GoodEnd());
    }

    void badending()
    {
        StartCoroutine(BadEnd());

    }

}
