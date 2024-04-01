using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float enemySpeed;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -1 * enemySpeed * Time.deltaTime, 0);
    }
}
