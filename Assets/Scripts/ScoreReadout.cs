using UnityEngine;
using UnityEngine.UI; //needed to use the Text Variable Type
using System.Collections;

public class ScoreReadout : MonoBehaviour
{
    //declare our variables
    Text text;
	
    // Use this for initialization
	void Start ()
    {
        //assigns the objects Text Component 
        //to the text variable declared above
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //updates the text on screen to the global score variable
        text.text = "Score: " + GlobalVar.score.ToString();
	}
}
