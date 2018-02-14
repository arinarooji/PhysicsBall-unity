using UnityEngine;
using System.Collections;

public class RandomBallMove : MonoBehaviour
{
    //declare public variables
    public float amountOfForce;
    public float timer;
   
    //declare private variables
    Rigidbody2D rb;
    float startTimer;

	// Use this for initialization
	void Start ()
    {
        //assigns the rigidbody of this object
        //to the rb variable
        rb = GetComponent<Rigidbody2D>();
        //sets the start timer for the game
        startTimer = timer;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //the timer counts down until it reaches 0
        //then it applies a random force to the ball
        //then it resets the timer
        timer -= 1 * Time.deltaTime;
        if(timer < 0)
        {
            RandomForce();
            timer = startTimer;
        }
	}

    //this function is used for applying a random force to 
    //the ball
    void RandomForce()
    {
        int rnd = Random.Range(0, 3); //picks a random number
        //uses the random number to decide which direction to apply a force
        switch (rnd)
        {
            case 0: rb.AddForce(Vector2.up * amountOfForce, ForceMode2D.Impulse); break;
            case 1: rb.AddForce(new Vector2(-1, 1) * amountOfForce, ForceMode2D.Impulse); break;
            case 2: rb.AddForce(new Vector2(1, 1) * amountOfForce, ForceMode2D.Impulse); break;
        }
        
    }
}
