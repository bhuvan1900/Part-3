using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class enemy : MonoBehaviour
{
    
    public float speed;
    private static int totalScore = 0;
    private static int currentScore = 0;
    
    // Update is called once per frame
    protected virtual void Update()
    {
        transform.Translate(0, -1 * speed * Time.deltaTime, 0);

        if (transform.position.y < 0)
        {
            addScore(5);
            Destroy(gameObject);
        }
    }

    public static void addScore(int score=0)
    {
        totalScore += score;

        if(totalScore!= currentScore)
        {
            Debug.Log("SCORE="+ totalScore);
            currentScore = totalScore;
        }
    }

   
    public static int Total(){
        return totalScore;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        gameOver();
    }
 
    protected virtual void gameOver()
    {
        Debug.Log("GAME OVER");
    }
}
