using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class TrickShot : MonoBehaviour
{
    [Range(0, 1)]
    public float b;
    public AnimationCurve roll;
    public Transform left;
    public Transform right;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(left.position, right.position, roll.Evaluate(b));
    }
}
