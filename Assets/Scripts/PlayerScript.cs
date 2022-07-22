using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    public int forwardForce;
    public int sideForce;

    // Start is called before the first frame update
    void Start()
    {
        //rb.useGravity = false;
        
        Debug.Log("Player start."); 
    }

    // Update is called once per frame
    // FixedUpdate() is recommended when using UnityPhysics
    void FixedUpdate()
    {

        if (Input.GetKey("w"))
        {
            rb.AddForce(forwardForce, 0, 0 * Time.deltaTime);
            //Debug.Log("W was pressed");
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(-forwardForce, 0, 0 * Time.deltaTime);
            //Debug.Log("S was pressed");
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, sideForce * Time.deltaTime, ForceMode.VelocityChange);
            //Debug.Log("A was pressed");
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, -sideForce * Time.deltaTime, ForceMode.VelocityChange);
            //Debug.Log("D was pressed");
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        /*        switch ()
                {
                    case Input.GetKey("w"):
                        rb.AddForce(forwardForce, 0, 0 * Time.deltaTime); //Time.deltaTime is needed to fix framerate dependecy of speed
                        break;
                    case Input.GetKey("a"):
                        rb.AddForce(0, 0, sideForce * Time.deltaTime); //Time.deltaTime is needed to fix framerate dependecy of speed
                        break;
                }*/
    }
}
