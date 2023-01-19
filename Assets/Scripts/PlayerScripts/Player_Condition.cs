using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script will manage the player's health and mana. I think it will be beneficial to keep these seperate
public class Player_Condition : MonoBehaviour
{
    //Components used by unity 
    public BoxCollider2D Box_Col; 



    //Global variables used by the script 

        //variable to keep up with health. This number will decide the amount of health displayed
       public float Max_Health, Current_Health;

        //variable to keep up with Mana. This number will decide the amount of Mana displayed
       public float Max_Mana, Current_Mana;

    //Jump Height and Movement Speed 
    float Jump_Height, Movement_Speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
