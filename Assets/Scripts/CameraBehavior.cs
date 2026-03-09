using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    /* The goal of this script is to have the "Camera also stay
     * behind the player(Green Capsule) to follow its movements. */


    // create a vector CamOffset to keep track of the position of the camera
    public Vector3 CamOffset = new Vector3 (0f, 1.2f, -2.6f);

    // this Transform variable will hold the players position
    public Transform _target;
    void Start()
    {
        // set _target to the players current position
        _target = GameObject.Find("Player").transform;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        this.transform.position = _target.TransformPoint(CamOffset);
        this.transform.LookAt(_target);
    }
}
