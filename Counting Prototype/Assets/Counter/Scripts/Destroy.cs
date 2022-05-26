using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    public Counter counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = GameObject.Find("Box").GetComponent<Counter>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        if(collision.gameObject.CompareTag("Ground"))
            {
            Debug.Log("Game Over!");
            Destroy(gameObject);
            counter.Count = 0;
            counter.CounterText.text = "Count : " + counter.Count;
        }

    }
}
