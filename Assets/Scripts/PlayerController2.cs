using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class PlayerController2 : MonoBehaviour
{
    public float side = 5000;
    public float forward = 5000;
    public Rigidbody rb;
    private float movementX;
    private float movementY;
    public TextMeshProUGUI score;

    public bool isJump = false;
    public float jumpForce = 2f;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }



    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, forward * Time.deltaTime);
        if (Input.GetKey("right"))
        {
            rb.AddForce(side * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("left"))
        {
            rb.AddForce(-side * Time.deltaTime, 0, 0);
        }

        score.text = transform.position.z.ToString("0");
        isJump = Input.GetButtonDown("Jump");

        if ((transform.position.y <= .5) && (isJump))
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
    }
    
}
