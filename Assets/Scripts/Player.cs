using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float movespeed;
    public static Player Instance;

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = Vector3.right * horizontal * movespeed;
        
    }

    void Update()
    {

    }

    /*public void ResetPlayer(bool Active)
    {
        if (Active) {
            //TODO  ResetPlayer  
            //Reset Position
            //Reset Roate
        }
    }*/
}