using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AufloesenScript : MonoBehaviour
{
    public void Aufloesen()
    {
        StartCoroutine(DeathAnimation());
    }
    public IEnumerator DeathAnimation()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        float fade = 0.9f;
        for (; ; )
        {
            fade -= 0.0075f;
            if (fade > 0)
            {
                renderer.material.SetFloat("_Fade", fade);
            }
            else
            {
                this.gameObject.SetActive(false);
                StopAllCoroutines();
            }
            yield return new WaitForEndOfFrame();
        }
    }
    public void Aufloesen(float start, float fadeMultiplikator)
    {
        StartCoroutine(DeathAnimation(start, fadeMultiplikator));
    }
    public IEnumerator DeathAnimation(float start, float fadeMultiplikator)
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        float fade = start;
        for (; ; )
        {
            fade -= 0.0075f * fadeMultiplikator;
            if (fadeMultiplikator > 0)
            {
                if (fade > 0)
                {
                    renderer.material.SetFloat("_Fade", fade);
                }
                else
                {
                    this.gameObject.SetActive(false);
                    StopAllCoroutines();
                }
            }
            else
            {
                if (fade < 1)
                {
                    renderer.material.SetFloat("_Fade", fade);
                }
                else
                {
                    renderer.material.SetFloat("_Fade", 1);
                    yield break;
                }
            }
            yield return new WaitForEndOfFrame();
        }
    }
}
