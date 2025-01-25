using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float movingSpeed = 2.0f;
    float xAxisMove;
    float yAxisMove;

    
    public Transform xFlipGfx;

    //Disabling Movement
    bool controllerInteractable;
    // Start is called before the first frame update
    void Start()
    {
        controllerInteractable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(controllerInteractable)
        {
            Movement();
        }
        
    }

    public void Movement()
    {
        Flip();
        //Getting the values of x and y movement
        xAxisMove = Input.GetAxisRaw("Horizontal");
        yAxisMove = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(xAxisMove * movingSpeed * Time.deltaTime, yAxisMove * movingSpeed * Time.deltaTime, 0);
        //move.Normalize();
        transform.localPosition = transform.position + move;

    }

    public void Flip()
    {
        //for xAxis Flip
        if(xAxisMove == 1f)
        {
            //flipping the sprite to the positive xAxis
            xFlipGfx.localScale = new Vector3(xAxisMove, 
                xFlipGfx.localScale.y, 
                xFlipGfx.localScale.z);
        }

        else if(xAxisMove == -1f)
        {
            //flipping the Sprite to the negative xAxis
            xFlipGfx.localScale = new Vector3(xAxisMove, 
                xFlipGfx.localScale.y, 
                xFlipGfx.localScale.z);

        }
    }
}
