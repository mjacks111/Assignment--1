using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    public Text loseText;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            loseText.gameObject.SetActive(true);

            FindObjectOfType<GameManager>().EndGame();


        }
    }
}
