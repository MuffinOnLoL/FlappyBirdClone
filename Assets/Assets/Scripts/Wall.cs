//Wall.cs - Colin Klein
//September 19th - 2022
//This script defines the movement of the walls and coin that move toward the player

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private bool dead = false;  //Creates a variable "dead" and assigns it a value of false

    public float speed;         //Creates a variable "speed" and makes it public for use in Inspector




    // Update is called once per frame
    void Update()
    {
        if (dead)
        {
            Time.timeScale = 0;
        }
        else
        {
            Move();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bird")
        {
            dead = true;
            Debug.Log("GAME HAS ENDED");
        }
    }
    private void Move()
    {
        transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
    }
}
