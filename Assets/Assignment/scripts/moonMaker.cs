using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moonMaker : MonoBehaviour
{
    public GameObject prefab;
    //min time between spawns
    private float min = 1f;
    //max time between spawns
    private float max = 10f;

    private void Start()
    {
        //coroutine that makes prefabs
        StartCoroutine(InstantiatePrefab());
    }

    private System.Collections.IEnumerator InstantiatePrefab()
    {
        while (true)
        {
            // Wwait for random amount of time
            float interval = Random.Range(min, max);
            yield return new WaitForSeconds(interval);

            // instantiate the prefab
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }
}
