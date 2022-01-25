using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private float  HorizontalInput;
    private float VerticalInput;
    public float speed = 5f;
    public float rotatesepeed = 5f;
    private Animator boton;
    private Animator door;


    void Start()
    {
        boton = GameObject.Find("button").GetComponent<Animator>();
        door = GameObject.Find("puerta").GetComponent<Animator>();
    }

    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        transform.Translate(speed * Vector3.forward * VerticalInput * Time.deltaTime);
        transform.Rotate(rotatesepeed * Vector3.up * HorizontalInput * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider othercollider)
    {
        if (othercollider.gameObject.CompareTag("button"))
        {
            boton.SetBool("press", true);
            door.SetBool("open", true);
        }

        if(othercollider.gameObject.CompareTag("close"))
        {
            door.SetBool("open", false);
        }
    }
    

}
