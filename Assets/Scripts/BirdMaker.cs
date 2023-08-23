using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMaker : MonoBehaviour
{
    [SerializeField] Transform point;
    void OnCollisionEnter2D(Collision2D other)
    {
        
        if(other.gameObject.tag=="Ground")
        {
            Debug.Log(point.position);
            Instantiate(BirdSelector.instance.Bird,point.position,Quaternion.identity);
        }
    }
}
