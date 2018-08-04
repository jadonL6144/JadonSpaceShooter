using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Moving : MonoBehaviour {
    /*
    public float speed;
    public float tilt;
    public Boundary boundary;
	
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rigidbody.velocity = movement * speed;

        rigidbody.position = new Vector3
        (
            Mathf.Clamp(rigidbody.position.x, boundary.Xmin, boundary.Xmax),
            0.0f,
            Mathf.Clamp(rigidbody.position.z, boundary.Zmin, boundary.Zmax)
        );

        rigidbody.rotation = Quaternion.Euler(0.0f, 0.0f, rigidbody.velocity.x * -tilt);
	}*/
}
