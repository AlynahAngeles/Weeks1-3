using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinger : MonoBehaviour
{
    public AnimationCurve ping;
 
    [Range(0,1)]
    public float p;

    public Vector3 scale;

    void Start()
    {
        p = 0;
        scale = transform.localScale;
    }

    void Update()
    {

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(mousePos.x > -5 && mousePos.x < -3 && mousePos.y > -2 && mousePos.y < 2)
        {

            p += Time.deltaTime;

            if(p > 1)
            {

                p = 0;

            }

            transform.localScale = Vector2.one * ping.Evaluate(p);

        }

        else{
            transform.localScale = scale;
            p = 0;
        }

    }
}
