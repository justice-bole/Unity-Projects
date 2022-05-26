using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float horizontalInput;
    [SerializeField] float speed = 2.0f;
	public GameObject character;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
	void Update()
	{
		horizontalInput = Input.GetAxisRaw("Horizontal");
		transform.Translate(Vector3.forward * horizontalInput * speed * Time.deltaTime);
	
	}
}

