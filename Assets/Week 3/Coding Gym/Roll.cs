using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Roll : MonoBehaviour
{
    public AnimationCurve roll;

    [Range(0, 1)]
    public float b;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        b += Time.deltaTime;

        if (b > 1)
        {
            b = 0;
        }

        transform.localScale = Vector2.one * roll.Evaluate(b);

    }
}
