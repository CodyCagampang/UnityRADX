using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Obstacle : MonoBehaviour
{
    PlayerMovement playerMovement;
     
    private void Start() {
      playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
    }


    private void OnCollisionEnter (Collision collision)
    {
      if (collision.gameObject.name == "Player"){
      //Kill The Player 
      playerMovement.Die();

    }

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
