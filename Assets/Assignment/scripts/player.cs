using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{
    public float playerSpeed;
    private float target;
    public bool control=true;
    

    private void Update()
    {
        if (control)
        {
            float iowa = Input.GetAxis("Horizontal");
            //transform.Translate(direction * playerSpeed * Time.deltaTime, 0, 0);
            transform.Translate(new Vector3(iowa * playerSpeed * Time.deltaTime,0, 0));
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent <SpriteRenderer>() != null) 
        {
            control = false;
        }    
    }
}