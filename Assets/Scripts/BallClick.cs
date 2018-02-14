using UnityEngine;
using System.Collections;

public class BallClick : MonoBehaviour
{
    //declare our variables
    Rigidbody2D rb;
    public float amountOfForce;

    //this function happens is called when the game begins
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //assign the rigidbody2D variable declared above
    }

    //this function is called when the player
    //clicks on the ball
    void OnMouseDown()
    {
        //adds an upward force (Vector2.up) based on
        //the number entered in the editor (amountOfForce)
        //and used the Impulse force mode
        rb.AddForce(Vector2.up * amountOfForce, ForceMode2D.Impulse);
    }
}
