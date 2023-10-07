using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redlightfader : MonoBehaviour
{
    public Light redLight;
    public float fadeDuration = 2f;
    public float minIntensity = 0f;
    public float maxIntensity = 1f;

    private void Start()
    {
        StartCoroutine(FadeRedLight());
    }

    private IEnumerator FadeRedLight()
    {
        while (true)
        {
            yield return StartCoroutine(FadeLightIntensity(minIntensity, maxIntensity, fadeDuration));
            yield return StartCoroutine(FadeLightIntensity(maxIntensity, minIntensity, fadeDuration));
        }
    }

    private IEnumerator FadeLightIntensity(float startIntensity, float targetIntensity, float duration)
    {
        float currentTime = 0f;

        while (currentTime < duration)
        {
            float intensity = Mathf.Lerp(startIntensity, targetIntensity, currentTime / duration);
            redLight.intensity = intensity;
            currentTime += Time.deltaTime;
            yield return null;
        }

        redLight.intensity = targetIntensity;
    }
}