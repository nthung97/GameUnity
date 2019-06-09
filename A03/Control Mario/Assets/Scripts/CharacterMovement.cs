using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {
    public float speed = 1.0f;
    bool isOnGround = true;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed, 0));
            GetComponent<SpriteRenderer>().flipX = false;

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<SpriteRenderer>().flipX = true;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));
        }
        if(Input.GetKey(KeyCode.Space) && isOnGround == true)
        {
            isOnGround = false;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 20 * speed));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOnGround = true;
        if(collision.gameObject.name == "enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
