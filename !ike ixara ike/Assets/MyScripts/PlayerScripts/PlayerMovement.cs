using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float movingSpeed = 2.0f;
    float xAxisMove;
    float yAxisMove;

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
        //Getting the values of x and y movement
        xAxisMove = Input.GetAxisRaw("Horizontal");
        yAxisMove = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(xAxisMove * movingSpeed * Time.deltaTime, yAxisMove * movingSpeed * Time.deltaTime, 0);
        transform.localPosition = transform.position + move;
    }
}
