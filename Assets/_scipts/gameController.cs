using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour {

    public GameObject ball;
    Vector3 mousePos;
    Vector3 ballPos;
    Vector3 kuvvet;
  
    private void OnMouseUp()
    {
            
            ballPos = ball.transform.position;
            mousePos = Input.mousePosition;
            ballPos = Camera.main.WorldToViewportPoint(ballPos);
            mousePos = Camera.main.ScreenToViewportPoint(mousePos);
            kuvvet = new Vector3((mousePos.x - ballPos.x) * 1000, 0, (mousePos.y - ballPos.y) * 1000);
            ball.GetComponent<Rigidbody>().velocity = new Vector3(0, 0);
            ball.GetComponent<Rigidbody>().AddForce(kuvvet);
           
    }

   
}

