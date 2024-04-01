using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float playerSpeed;
    

    
    private void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        transform.Translate (direction * playerSpeed * Time.deltaTime,0, 0);


    }
}