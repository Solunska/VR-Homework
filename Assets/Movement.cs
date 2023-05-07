using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Transform vrPlayer;
    public float lookDownAngle = 25.0f;
    public float speed = 3.0f;
    public bool moveForward;
    private CharacterController cc;


    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    void Update()
    {
        if(vrPlayer.eulerAngles.x >= lookDownAngle && vrPlayer.eulerAngles.x < 90.0f){
            moveForward = true;
        } 
        else {
            moveForward = false;
        }
        if(moveForward){
            Vector3 forward = vrPlayer.TransformDirection(Vector3.forward);
            cc.SimpleMove(forward * speed);
        }
    }
}
