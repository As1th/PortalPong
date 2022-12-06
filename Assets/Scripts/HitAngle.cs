using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitAngle : MonoBehaviour
{
    public GameObject player;
    public AudioSource hit;
    // Start is called before the first frame update
    void Start()
    {

    }
    
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Ball")
        {
            hit.Play();
            player = collision.gameObject;
        //   player.GetComponent<Rigidbody>().velocity = new Vector3(player.GetComponent<Rigidbody>().velocity.x, player.GetComponent<Rigidbody>().velocity.y, 0);
            var relativeIntersectY = (transform.position.z + (20 / 2)) - player.transform.position.z;
            print(relativeIntersectY);
            var normalizedRelativeIntersectionY = (relativeIntersectY - (20 / 2));
            var bounceAngle = normalizedRelativeIntersectionY * 7f;

            float ballVx = 40 * Mathf.Cos(bounceAngle);
            float ballVy = 40 * -Mathf.Sin(bounceAngle);

            player.GetComponent<Rigidbody>().velocity = new Vector3(player.GetComponent<Rigidbody>().velocity.x, player.GetComponent<Rigidbody>().velocity.y,ballVy);

            if (Mathf.Abs(player.GetComponent<Rigidbody>().velocity.x) < 40)
            {
                if (player.GetComponent<Rigidbody>().velocity.x >= 0)
                {
                    player.GetComponent<Rigidbody>().velocity = new Vector3(40, player.GetComponent<Rigidbody>().velocity.y, player.GetComponent<Rigidbody>().velocity.z);
                } else {

                    player.GetComponent<Rigidbody>().velocity = new Vector3( -40, player.GetComponent<Rigidbody>().velocity.y, player.GetComponent<Rigidbody>().velocity.z);
                }
            }
        }
    }
    
    /*
     private void OnTriggerEnter(Collider other)
     {

        if (other.gameObject.tag == "Ball")
        {
            print("sd");
            player = other.gameObject;
           // player.GetComponent<Rigidbody>().velocity = Vector3.zero;
           // this.gameObject.GetComponent<Collider>().enabled = false;
            var relativeIntersectY = (transform.position.z + (20 / 2)) - player.transform.position.z;

            var normalizedRelativeIntersectionY = (relativeIntersectY - (20 / 2));
            var bounceAngle = normalizedRelativeIntersectionY * 5.5f;
            print(bounceAngle);
            float ballVx = 40 * Mathf.Cos(bounceAngle);
            float ballVy = 40 * -Mathf.Sin(bounceAngle);

            player.GetComponent<Rigidbody>().velocity = new Vector3(-ballVx, 0, ballVy);
           //this.gameObject.GetComponent<Collider>().enabled = true;
        }
    }
    */
    // Update is called once per frame
    void Update()
    {
        
    }
}
