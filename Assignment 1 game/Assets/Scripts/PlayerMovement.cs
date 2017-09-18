using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;

    public float fowardForce = 2000f;

    public float sideForce = 500f;

    public Text loseText;

   


    void FixedUpdate ()
    {
        rb.AddForce(0, 0, fowardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            loseText.gameObject.SetActive(true);
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
