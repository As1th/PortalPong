using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMover : MonoBehaviour
{
    public GameObject ball;
    float y;
    public float damp;
    public GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        damp = 0.42f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        if (ball.GetComponent<Rigidbody>().velocity.x > 0)
        {
            if (ball.transform.position.z > transform.position.z && ball.transform.position.z-0.2f > transform.position.z && ball.transform.position.z+0.2f > transform.position.z)
            {
                if (transform.position.z < 38)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + damp);
                }
            }
            else if (ball.transform.position.z < transform.position.z && ball.transform.position.z-0.2f < transform.position.z && ball.transform.position.z+0.2f < transform.position.z)
            {
                if (transform.position.z > -38)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - damp);
                }

            }
        }
        else 
        {
            if (transform.position.z > 0.3f)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.3f);
            }
            else if (transform.position.z < 0.3f)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.3f);
            }

        }
    }
}
