using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//This script will control the player controls and movement 
public class Player_Controller : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float Jumpstrength, MovementSpeed;
    public SpriteRenderer sprite;

    //This variable is a possible way to do the jumping 
    public Boolean can_Jump; 
    public Boolean can_Move;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Jump
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.velocity = Vector2.up * Jumpstrength;
        }
        //Move Right
        if (Input.GetKey(KeyCode.D) == true)
        {
            myRigidbody.velocity = Vector2.right * MovementSpeed;
            sprite.flipX = false;
         
        }
        //Move Left
        if (Input.GetKey(KeyCode.A) == true)
        {
            myRigidbody.velocity = Vector2.left * MovementSpeed;
            sprite.flipX = true;
        }
        
    }
}
