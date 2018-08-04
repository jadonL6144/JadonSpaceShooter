using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

    public float speed;
    public Rigidbody rigidbody;

	void Start () {

        rigidbody.velocity = transform.forward * speed;

	}
	
}
