using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public GameObject ball;
    Vector3 aradakiMesafe;
    void Start()
    {
        aradakiMesafe = transform.position - ball.transform.position;
    }

    
    void LateUpdate()  //LateUpdate() t�m update'ler bittikten sonra �al���r.
    {
        transform.position = ball.transform.position + aradakiMesafe;
    }
}
