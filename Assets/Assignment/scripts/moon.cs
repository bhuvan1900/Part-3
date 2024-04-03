using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class moon : enemy
{
    public float delay = 1.5f;
    public float sizeIncrease = 0.1f;
    public float interval = 2f;

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(increaserCoroutine());
    }

   IEnumerator increaserCoroutine()
    {
        yield return new WaitForSeconds(delay);

        while (true)
        {
            Vector3 targetScale = transform.localScale + new Vector3(sizeIncrease, sizeIncrease, 0f);
            Vector3 originalScale = transform.localScale;
            float elapsedTime = 0f;

            while (elapsedTime < interval)
            {
                transform.localScale = Vector3.Lerp(originalScale, targetScale, elapsedTime / interval);
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            transform.localScale = targetScale;

            yield return new WaitForSeconds(interval);
        }
    }

}