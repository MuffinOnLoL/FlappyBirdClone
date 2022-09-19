//Bird.cs - Colin Klein
//September 19th - 2022
//This script will define how the player object will be controlled/react to objects around it

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
//This creates the different attributes for the object for use within the code

//Private allows for the attribute to only be used within the certain script
    private Rigidbody2D body;           //Creates a variable "body" to modify and use the existing Rigidbody2D attribute
    private float horizontalInput;      //Creates a variable "HorizontalInput" to assign the players input using the 'A' and 'D' keys 

//Public allows for the attribute to be modified outside the script via other scripts or Unity inspector
    public float speed;                 //Creates a variable "speed" to modifiy the rate at which the player object moves
    public float jumpCooldown = 0.00f;  //Creates a variable "jumpCooldown" and defaults it to 0 to modify how long until the player can jump again
    public float jumpPower;             //Creates a variable "jumpPower" that can be modified to determine how powerful the jump will be


//Update is constantly called every frame in the game
    void Update()
    {
            //body.velocity determines how many units/second a rigidbody is moving.
            //  By using "new Vector2();" I can reassign the objects location based on the given horizontal input from the player
            //as well as the speed specified.
            //  By using "deltaTime", I can determine how many seconds since the last frame and use this to determine the cooldown
            //for the players jump.
        jumpCooldown += Time.deltaTime;

            //Input.GetKey will gather information from the specified key on the keyboard (Spacebar for example). Once this key is 
            //  pressed, it calls upon the "Jump()" function
        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    //Creates "Jump()" that specifies how the bird will achieve "flight"
    private void Jump()
    {
            //  Specifies that "jumpCooldown" MUST be under 0.25 seconds since the last frame in order to use the jump command once more
            //(Bear in mind that a float must contain a whole number as well as an f that follows the decimal number.)
        if (jumpCooldown > 0.25f)
        {
            body.velocity = new Vector2(body.velocity.x, jumpPower);    //Assigns the birds velocity on the Y-axis to the value of jumpPower assigned on click. Otherwise causes the bird to drop.
            jumpCooldown = 0;                                           //Resets the jumpcooldown each time jump is called
            Debug.Log("I JUMPED");                                      //(BUGTESTING) Only used to output the text to test that the if statement is functioning correctly
        }
    }

}
