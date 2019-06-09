using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicControl : MonoBehaviour {
    Vector2 newPos;

    public float speed = 1.0f;
	// Use this for initialization
	void Start () {
        newPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow))
        {
            newPos.x -= speed;

        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            newPos.x += speed;
        }
        transform.position = newPos;
	}
}
