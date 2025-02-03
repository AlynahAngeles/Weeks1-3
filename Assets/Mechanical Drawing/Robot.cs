using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour //Initiate public class under name "Robot"
{
    public float robot = 0.01f; //State a public float under "robot" and set the value to 0.01
   
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 move = transform.position; //State a Vector3 under name "move"; set value to transform the position of a GameObject
        move.x += robot; //the x position of the move Vector will increase over time, making the robot move from left to right

        Vector2 screenPos = Camera.main.WorldToScreenPoint(move); //State a Vector2 with the name "screenPos"; this is locking the movement of the robot to the game's default camera view

        if(screenPos.x < 0 || screenPos.x > Screen.width){ //If the Vector screenPos x-position is less than 0 or greater than the screen width, that means the robot has reached the end of the screen and to execute this code...
            robot = robot * -1; //the robot's movement will turn around to where it came from by multiplying the robot's speed (0.01) by -1
        }

        transform.position = move; //the position's transform is equal to the move variable
    }
}
