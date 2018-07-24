using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {
    bool canFire;
    public float cooldown = 0.5f;
    float timeSinceLastShot;
    // Use this for initialization
	void Start () {
        canFire = true;
        timeSinceLastShot = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (!canFire) {
            timeSinceLastShot += Time.deltaTime;
            canFire |= timeSinceLastShot >= cooldown;
        }
	}

	internal void Fire()
	{
        if(canFire){
			Debug.Log("Fire");
            canFire = false;
            timeSinceLastShot = 0.0f;
        }
	}
}
