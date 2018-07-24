using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    internal void Move (float direction) {
        if(direction > 0.0f || direction < 0.0f){
			Debug.Log("Move " + direction.ToString());
        }
    }
}
