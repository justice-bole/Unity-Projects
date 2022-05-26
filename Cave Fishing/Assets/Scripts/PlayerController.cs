using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    Animator anim;
    float horizontalInput;
    float verticalInput;
    float zBound = 15;
    private bool sprinting;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if(Input.GetButton("Sprint") )
        {
            speed = 4.0f;
        }
        else {
            speed = 3.0f;
        }

        if(transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }
        if(transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
        if (verticalInput < 0)
        {
            transform.Translate((Vector3.forward * verticalInput).normalized * speed * Time.deltaTime);
            anim.SetBool("isIdle", true);
            anim.SetBool("isRight", false);
            anim.SetBool("isLeft", false);
            anim.SetBool("isBack", false );
        } 
        else if (verticalInput > 0)
        {
            transform.Translate((Vector3.forward * verticalInput).normalized * speed * Time.deltaTime);
            anim.SetBool("isIdle", false);
            anim.SetBool("isRight", false);
            anim.SetBool("isLeft", false);
            anim.SetBool("isBack", true);
        }
        if (horizontalInput < 0)
        {
            transform.Translate((Vector3.right * horizontalInput).normalized * speed * Time.deltaTime);
            anim.SetBool("isIdle", false);
            anim.SetBool("isRight", false);
            anim.SetBool("isLeft", true);
            anim.SetBool("isBack", false);
        }
        else if (horizontalInput > 0)
        {
            transform.Translate((Vector3.right * horizontalInput).normalized * speed * Time.deltaTime);
            anim.SetBool("isIdle", false);
            anim.SetBool("isRight", true);
            anim.SetBool("isLeft", false);
            anim.SetBool("isBack", false);
        }
        
    }
}
