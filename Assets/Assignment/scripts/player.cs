using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{
    public float playerSpeed;
    private float target;
    //player has control over the sun at the start
    public bool control= true;
    
    // i wanted the sun to spin around when it collides.

    private void Update()
    {
        if (control)
        {
            //if the player has control, they can move horizontally
            float iowa = Input.GetAxis("Horizontal");
            transform.Translate(new Vector3(iowa * playerSpeed * Time.deltaTime,0, 0));
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        //the player loses control if they collide with gameobjects with spriterenderer.
        //had to add sr cuz had to constrain sun with colliders so it doesnt go offscreen
        if (collision.gameObject.GetComponent <SpriteRenderer>() != null) 
        {
            control = false;
        }    
    }
}