using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscillateCenter : MonoBehaviour
{
    public bool isHeadingUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.z >= 40)
        {
            isHeadingUp = false;
        }
        else if (transform.position.z <= -40)
        {
            isHeadingUp = true;
        }

        if (isHeadingUp)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.4f);
        }
        else {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.4f);
        }
    }
}
