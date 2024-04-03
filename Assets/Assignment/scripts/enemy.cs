using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

//base class
public class enemy : MonoBehaviour
{
    
    public float speed;
    //float for score
    private static int totalScore = 0;
    //float for debug log
    private static int currentScore = 0;
    

    protected virtual void Update()
    {
        //move enemy down 
        //ended up using gravity a lot instead but public base speed was helpful to fine tune
        transform.Translate(0, -1 * speed * Time.deltaTime, 0);

        //check if enemy is below 0 in y-axis and then increase the score by 5 
        //and then destroy to avoid lots of additions
        if (transform.position.y < -10)
        {
            addScore(5);
            Destroy(gameObject);
        }
    }

    //add score
    public static void addScore(int score=0)
    {
        totalScore += score;

        //checks if score has changed
        if(totalScore!= currentScore)
        {
            Debug.Log("SCORE="+ totalScore);
            currentScore = totalScore;
        }
    }

   //total score
    public static int Total(){
        return totalScore;
    }

    //destroys the game object if collision with player. (no enemy enemy collisions because layer matrix)
    //didnt have it as a trigger because i wanted the sun to rotate after death
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        gameOver();
    }
 
    //a debug log to display game overs and something to overrite
    protected virtual void gameOver()
    {
        Debug.Log("GAME OVER");
    }
}
