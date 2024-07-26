using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rgbd2d;
    Vector3 movementVector;
    [SerializeField]float movementSpeed = 3f;
    Vector3 scaler;
    bool facingRight = true;

    private void Awake()
    {
        rgbd2d = GetComponent<Rigidbody2D>();
        movementVector = new Vector3();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movementVector.x = Input.GetAxisRaw("Horizontal");
        movementVector.y = Input.GetAxisRaw("Vertical");
        //si va a la derecha haga flip
        if(Input.GetAxis("Horizontal") < 0 && !facingRight)
        {
            scaler = transform.localScale;
            scaler.x *= -1;
            transform.localScale = scaler;
            facingRight = true;
        }
        else if((Input.GetAxis("Horizontal") > 0 && facingRight))
        {
            scaler = transform.localScale;
            scaler.x *= -1;
            transform.localScale = scaler;
            facingRight = false;
        }
        movementVector *= movementSpeed;
        rgbd2d.velocity = movementVector;
    }
}
