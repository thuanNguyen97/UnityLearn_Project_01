using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 4.32f, -6.9f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate() //LateUpdate() is called after the Update() called
    {
        //offset the camera behind the player be adding the vector3 position
        transform.position = player.transform.position + offset; //follow player
    }
}
