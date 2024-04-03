using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star : enemy
{
    public Transform target;

    protected override void Update()
    {
        base.Update();

        Vector3 direction = (target.position - transform.position).normalized;
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
