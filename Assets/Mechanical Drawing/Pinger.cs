using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinger : MonoBehaviour //Initiate public class under name "Pinger"
{
    public AnimationCurve ping; //State AnimationCurve under name "ping"
 
    [Range(0,1)] //Set the float's range from 0 to 1
    public float p; //State public float under variable p

    public Vector3 scale; //State public Vector under name "scale"

    void Start() //Elements that are played once
    {
        p = 0; //Set variable p value to 0
        scale = transform.localScale; //State "scale" value to change the scale of an object
    }

    void Update() //Elements that are repeatedly played
    {

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //State a Vector3 called "mousePos"; this line will look for the mouse input; restricted by the camera shown to player

        if(mousePos.x > -5 && mousePos.x < -3 && mousePos.y > -2 && mousePos.y < 2) //If the mouse X position is greater than -5 and less than -3, and the mouse Y position is greated than -2 and less than 2, then execute this code...
        {

            p += Time.deltaTime; //p will increase in value consistently if the mouse upholds the above requirements

            if(p > 1) //if p is greater than 1, execute this code...
            {

                p = 0; //Return p's value back to 0

            }

            transform.localScale = Vector2.one * ping.Evaluate(p); //transform the GameObject's base scale and multiply based on the value of p at the time; creates a pulsating effect

        }

        else{ //if the mouse position is anything other than the above mentioned, execute this code...

            transform.localScale = scale; //change the GameObject's scale
            p = 0; //execute the equation above with p = 0, resetting the pinger's size
        }
    }
}
