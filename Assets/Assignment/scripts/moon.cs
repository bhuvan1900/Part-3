using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class moon : enemy
{
    //initial delay to make sure its still small when it enters the screen
    public float delay = 1.5f;
    //size increase amount float
    public float sizeIncrease = 0.1f;
    //how long it will wait between size increase. didnt want a balloon
    public float interval = 2f;

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        //the coroutine 
        StartCoroutine(increaserCoroutine());
    }

   IEnumerator increaserCoroutine()
    {
        //initial delay
        yield return new WaitForSeconds(delay);

        //start increase
        while (true)
        {
            //calculate how big its gonna get by adding size increase to size 
            Vector3 targetScale = transform.localScale + new Vector3(sizeIncrease, sizeIncrease, 0f);
            Vector3 originalScale = transform.localScale;
            float elapsedTime = 0f;

            //the time has passed, start becoming big
            while (elapsedTime < interval)
            {
                //using lerp to gradually increase 
                transform.localScale = Vector3.Lerp(originalScale, targetScale, elapsedTime / interval);
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            //scale is now target scale
            transform.localScale = targetScale;

            //wait before next increase
            yield return new WaitForSeconds(interval);
        }
    }

}