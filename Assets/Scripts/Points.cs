using UnityEngine;
using System.Collections;

public class Points : MonoBehaviour
{
    //declare our variables
    public int numberOfPoints;

    //this function is called when the ball enters
    //one of the Scoring Objects
    void OnTriggerEnter2D(Collider2D other)
    {
        //increases the global score
        GlobalVar.score += numberOfPoints;
        //prints a message in the console window for testing
        Debug.Log("Score = " + GlobalVar.score);
    }
}
