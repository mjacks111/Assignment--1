﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour{

    public float speed;

    private Rigidbody rb;
    private int count;

    public Text countText;
    public Text winText;

    public float Speed
    {
        get
        {
            return speed;
        }

        set
        {
            speed = value;
        }
    }

    void Start ()
    {
       rb = GetComponent<Rigidbody>();
       count = 0;
       setCountText ();
       winText.text = "";
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

     void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag ("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
            setCountText();
        }
    }

    void setCountText ()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 12)
        {
            winText.text = "You Win!!";
            Invoke("Menu", 2f);
        }
    }

    void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
