using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LPointGrabber : MonoBehaviour
{
    public GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Ball")
         {
            gm.rightScore();
            gm.spawnBallRight();

        
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
