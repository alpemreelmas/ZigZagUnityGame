using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform positionOfBall;
    Vector3 difference;
    void Start()
    {
        difference = transform.position - positionOfBall.position;
    }


    void Update()
    {
        if (!BallMovement.isFall)
        {
            transform.position = positionOfBall.position + difference;
        }
        
    }
}
