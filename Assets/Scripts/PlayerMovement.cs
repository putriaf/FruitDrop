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
    
	float v = Input.GetAxis("Horizontal");
    rb.MovePosition(transform.position + transform.right * v * speed);
	// float h = Input.GetAxis("Horizontal") * speed;
               
    // rb.transform.Translate(h,0,0);
	
    }
}
