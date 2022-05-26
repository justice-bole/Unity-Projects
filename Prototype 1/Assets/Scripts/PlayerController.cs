using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 20.0f;
    [SerializeField] private float horsePower = 0f;
    [SerializeField] private float turnSpeed = 25.0f;
    [SerializeField] float rpm;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody playerRb;
    [SerializeField] GameObject centerOfMass;
    [SerializeField] TextMeshProUGUI speedometerText;
    [SerializeField] TextMeshProUGUI rpmText;
    [SerializeField] List<WheelCollider> allWheels;
    [SerializeField] int wheelsOnGround;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }

    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (IsOnGround())
        {
            playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);

            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        }
        speed = Mathf.RoundToInt(playerRb.velocity.magnitude * 2.237f);
        speedometerText.text = ("Speed: " + speed + "mph");

        rpm = (speed % 30) * 40;
        rpmText.SetText("RPM: " + rpm);
    }

    bool IsOnGround()
    {
        wheelsOnGround = 0;
        foreach (WheelCollider wheel in allWheels)
        {
            if(wheel.isGrounded)
            {
                wheelsOnGround++;
            }
        }
        if(wheelsOnGround == 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
