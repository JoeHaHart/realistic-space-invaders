using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {
    PlayerMovement movement;
    PlayerShooting shooting;
    bool firing;
	// Use this for initialization
	void Start () {
        movement = GetComponent<PlayerMovement>();
        shooting = GetComponent<PlayerShooting>();
	}
	
	// Update is called once per frame
	void Update () {

        float moveInput = Input.GetAxis("Horizontal");
        movement.Move(moveInput);

        float fire = Input.GetAxis("Fire1");
        if (fire > 0.9f) {
            shooting.Fire(); 
        }
	}
}
