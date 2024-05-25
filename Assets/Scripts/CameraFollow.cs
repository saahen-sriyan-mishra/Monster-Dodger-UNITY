using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //transform canera position
    private Transform player; //transform component

  
    private Vector3 tempPos;


    [SerializeField]
    private float maxX, minX;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform; //not player but Player
        
        
        //Debug.Log("The Selected Index: " + GameManager.Instance.CharIndex);
    }


    //Avoid glitch to folloe after the position of game object is calculated
    private void LateUpdate()
    {
        //Destroyed the game object player so return
        if (player == null) { return; }


        tempPos = transform.position; //camera pos.
        tempPos.x = player.position.x; //follow vector x = player tagged's x

        if (tempPos.x > maxX) 
        {
            tempPos.x = maxX;
        }
        if (tempPos.x < minX) 
        {
            tempPos.x = minX;
        }

       transform.position= tempPos; //camera is now given temp. variable
    }
}
