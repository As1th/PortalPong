using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TouchButtonUp;
    public GameObject TouchButtonDown;
    void Start()
    {

    }

    public void moveUp() {
        if (transform.position.z < 39)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.6f);
        }
    }

    public void moveDown()
    {
        if (transform.position.z > -39)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 0.6f);
        }
    }

       

// Update is called once per frame
void FixedUpdate()
    {
        if (Input.GetButton("Up") || Input.GetButton("W") || TouchButtonUp.GetComponent<TouchButton>().buttonPressed)
        {
            moveUp();
        
        }
        if (Input.GetButton("Down")||Input.GetButton("S") || TouchButtonDown.GetComponent<TouchButton>().buttonPressed)
        {
            moveDown();
        }
    }
}
