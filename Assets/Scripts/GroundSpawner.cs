using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject lastGround;
    
    void Start()
    {
        for (int i = 0; i < 40; i++)
        {
            CreateGround();
        }
    }

    public void CreateGround()
    {
        Vector3 direction;
        if (Random.Range(0, 2) == 0)
        {
            direction = Vector3.left;
        }
        else
        {
            direction = Vector3.forward;
        }
        
        lastGround = Instantiate(lastGround,lastGround.transform.position + direction,lastGround.transform.rotation);
    }
}
