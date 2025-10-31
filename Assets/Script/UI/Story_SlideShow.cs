using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story_SlideShow : MonoBehaviour
{
    [SerializeField]
    private GameObject slideShowobj;
    [SerializeField]
    private Image slideImage;
    [SerializeField]
    private Sprite[] slides;

    private int index = 0;
    private void OnEnable()
    {
        index = 0;
        StartCoroutine(StartSlide());
    }
    IEnumerator StartSlide()
    {
        while (index < slides.Length)
        {
            ShowSlide(index);
            yield return StartCoroutine(FadeIn());
            yield return new WaitForSecondsRealtime(2f);
            yield return StartCoroutine(FadeOut());
            index++;           
        }
        EndSlide();
    }
    private void ShowSlide(int index)
    {
        slideImage.sprite = slides[index];
        Time.timeScale = 0;
    }
    private void EndSlide()
    {
        slideShowobj.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    IEnumerator FadeIn()
    {
        Color color = slideImage.color;
        float duration = 1f;

        for (float a = 0f; a <= 1f; a += Time.unscaledDeltaTime / duration)
        {
            slideImage.color = new Color(color.r, color.g, color.b, a);
            yield return null;
        }

        slideImage.color = new Color(color.r, color.g, color.b, 1f);
    }

    IEnumerator FadeOut()
    {
        Color color = slideImage.color;
        float duration = 1f;

        for (float a = 1f; a >= 0f; a -= Time.unscaledDeltaTime / duration)
        {
            slideImage.color = new Color(color.r, color.g, color.b, a);
            yield return null;
        }

        slideImage.color = new Color(color.r, color.g, color.b, 0f);
    }

}
