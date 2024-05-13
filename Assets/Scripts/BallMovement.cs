using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Vector3 direction;
    [SerializeField]
    public float speed;
    [SerializeField]
    public GroundSpawner spawner;
    public static bool isFall;
    public float increaseSpeed;
    void Start()
    {
        direction = Vector3.forward;
        isFall = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= 0.5f)
        {
            isFall = true;
        }
        if (isFall)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            if(direction.x ==  0)
            {
                direction = Vector3.left;
            }
            else
            {
                direction = Vector3.forward;
            }
            speed += increaseSpeed * Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        Vector3 movement = direction * Time.deltaTime * speed;
        transform.position += movement;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Scor.scor++;
            collision.gameObject.AddComponent<Rigidbody>();
            spawner.CreateGround();
            StartCoroutine(RemoveGround(collision.gameObject));
        }
    }

    IEnumerator RemoveGround(GameObject removalObject)
    {
        yield return new WaitForSeconds(3f);
        Destroy(removalObject);
    }
}
