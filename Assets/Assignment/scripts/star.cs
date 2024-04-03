using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star : enemy
{
    public Transform target;

    private void Update()
    {
                   Vector3 direction = (target.position - transform.position).normalized;
            transform.Translate(direction * speed * Time.deltaTime);
    }

    protected override void gameOver()
    {
        Debug.Log("GAME OVER by star");
    }

}
