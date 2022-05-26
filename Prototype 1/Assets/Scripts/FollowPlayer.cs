using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private Vector3 offset = new Vector3(0, 5, -7);
  
    // Update is called once per frame
    void LateUpdate() //good for camera updates/controls
    {
        //sets camera position to players current position + offsets
        transform.position = player.transform.position + offset;
    }
}
