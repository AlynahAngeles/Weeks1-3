using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinger : MonoBehaviour
{
    public AnimationCurve ping;
 
    [Range(0,1)]
    public float p;

    void Start()
    {
        p = 0;
    }

    // Update is called once per frame
    void Update()
    {
        p += Time.deltaTime;

        if(p > 1)
        {
            p = 0;
        }

        transform.localScale = Vector2.one * ping.Evaluate(p);
    }
}
