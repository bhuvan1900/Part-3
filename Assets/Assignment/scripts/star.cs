using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star : enemy
{
    //place to put the player
    public Transform target;

    protected override void Update()
    {
        base.Update();

        //the star calculates the thing between the player and it and tries to change direction slightly while still moving down. 
        //speed float adjusts difficulty
        Vector3 direction = (target.position - transform.position).normalized;
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
