using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
     //   float random = Random.Range(-11,12);
      //  transform.rotation = Quaternion.Euler(0,random,0);

        rb = GetComponent<Rigidbody>();
       // rb.AddForce(transform.right*1875);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 92 || transform.position.x < -92 || transform.position.z > 62 || transform.position.z < -62)
        {
            transform.position = new Vector3(0,1.8f,0);
        }
    }
}
