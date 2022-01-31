using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_real_controller : MonoBehaviour
{
    private float speedadvance = 20f;
    private float rotationspeed = 110f;
    private Rigidbody playerRigidBody;

    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float VerticalInput = Input.GetAxis("Vertical");
        float HorizontalInput = Input.GetAxis("Horizontal");
        playerRigidBody.AddForce(gameObject.transform.forward * speedadvance * VerticalInput);
        transform.Rotate(gameObject.transform.up * rotationspeed * HorizontalInput * Time.deltaTime);
    }
}
