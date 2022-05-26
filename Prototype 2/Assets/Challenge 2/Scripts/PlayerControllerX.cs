using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timer = 0;

    // Update is called once per frame
    void Update()
    {
        timer = timer + 1 * Time.deltaTime;
        Debug.Log(timer);
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timer > .75f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timer = 0;
        }
    }
}
