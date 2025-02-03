using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnifyingGlass : MonoBehaviour //Initiate public class under the name "MagnifyingGlass"
{

    void Start()
    {
        
    }


    void Update() //Execute this code per frame
    {
        Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition); //State a Vector2 under name "mouse"; this line looks for input from the mouse position and is locked to the game's camera view'
        transform.position = mouse; //the Vector mouse will look for the mouse position and transform the GameObject's position based on where the mouse is located

    }
}
