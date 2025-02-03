using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    float robot = 0.01f;
   
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 move = transform.position;
        move.x += robot;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(move);

        if(screenPos.x < 0 || screenPos.x > Screen.width){
            robot = robot * -1;
        }

        transform.position = move;
    }
}
