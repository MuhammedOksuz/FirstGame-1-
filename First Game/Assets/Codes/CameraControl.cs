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

    
    void LateUpdate()  //LateUpdate() tüm update'ler bittikten sonra çalýþýr.
    {
        transform.position = ball.transform.position + aradakiMesafe;
    }
}
