using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class crescent : enemy
{
    
    public SpriteRenderer sr;
   
    //overrides the base gameover with a custom game over screen and a debug log too!
    protected override void gameOver()
    {
        Debug.Log("GAME OVER by crescent");
        sr.enabled = true;
        //img credit- Pixabay/CC0 Public Domain
    }
}
