//Coin.cs - Colin Klein
//September 19th - 2022
//This script defines how the coin will move and what occurs when the player object comes into contact with a coin object

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Coin : MonoBehaviour
{

    private bool dead = false;

    public GameObject coin;
    public float speed;

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
            Debug.Log("HIDING COIN");
            gameObject.SetActive(false);
        }
    }

    private void Move()
    {
        transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
    }

}
