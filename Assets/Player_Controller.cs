using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Boundary
{
    public float Xmin, Xmax, Zmin, Zmax;
}

public class Player_Controller : MonoBehaviour
{

    public float speed;
    public float tilt;
    public Boundary boundary;
    public Rigidbody rb;
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire){

            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);

        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");


        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.velocity = movement * speed;

        rb.position = new Vector3
        (
                Mathf.Clamp(rb.position.x, boundary.Xmin, boundary.Xmax),
            0.0f,
                Mathf.Clamp(rb.position.z, boundary.Zmin, boundary.Zmax)
        );

        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
    }
}
