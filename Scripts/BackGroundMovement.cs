using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMovement : MonoBehaviour {

    public float speed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(speed, 0,0);
    }
}