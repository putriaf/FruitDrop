using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
	public float speed = 5f; //Controls velocity multiplier

	Rigidbody rb; //Tells script there is a rigidbody, we can use variable rb to reference it in further script
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
     	//float xMove = Input.GetAxisRaw("Horizontal"); // d key changes value to 1, a key changes value to -1
 	//float zMove = Input.GetAxisRaw("Vertical"); // w key changes value to 1, s key changes value to -1
	//rb.velocity = new Vector3(xMove, rb.velocity.y, zMove) * speed; // Creates velocity in direction of value equal to keypress (WASD). rb.velocity.y deals with falling + jumping by setting velocity to y.    
	//rb.velocity = new Vector2(xMove, rb.velocity.y) * speed;
	//float h = Input.GetAxisRaw("Horizontal");
    	//Vector2 movement = new Vector2(h, rb.velocity.y);
    	//rb.velocity = Vector2.Lerp(rb.velocity, movement, LerpConstant);
	float v = Input.GetAxis("Horizontal");
     	rb.MovePosition(transform.position + transform.right * v * speed);
	//rb.velocity = new Vector2 (Input.GetAxisRaw ("Horizontal") * speed, rb.velocity.y);
	
    }

	// void FixedUpdate() {
	// 	Vector2 vel = rb.velocity;
	// 	vel.x = Input.GetAxis("hHorizontal") * speed;
	// 	rb.velocity = vel;
	// }
}
