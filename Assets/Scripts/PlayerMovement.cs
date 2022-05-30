using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
	public float speed = 5f; //Controls velocity multiplier
    private Touch touch;
    private float speedModifier;
	Rigidbody rb; //Tells script there is a rigidbody, we can use variable rb to reference it in further script
    float worldWidth         = 14f;  //serialized, example value
    float ratioScreenToWorld = 2.0f; //serialized, example value

    float screenWidth        = (float) Screen.width;
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
	// if(Input.touchCount >0){
    //     touch = Input.GetTouch(0);
    //     if(touch.phase == TouchPhase.Moved){
    //         //transform.position.x
    //         rb.MovePosition(transform.position + transform.right * touch.deltaPosition.x * speed);
    //     }
    // }
    

    if (Input.touchCount > 0)
    {
        touch = Input.GetTouch(0);
        if (touch.phase == TouchPhase.Moved)
        {
            float horizontal = touch.deltaPosition.x;
            transform.position +=
                new Vector3(0f, 0f, horizontal * (worldWidth / screenWidth) * ratioScreenToWorld);
            //clamp, or whatever
        }
    }
    }
}
