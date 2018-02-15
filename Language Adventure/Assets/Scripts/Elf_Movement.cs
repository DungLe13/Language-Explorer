using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf_Movement : MonoBehaviour {
    Rigidbody physicBody;
    public float speed = 5;

    // Use this for initialization
    void Start () {
        physicBody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        transform.Rotate(0, horizontalInput * speed, 0);
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * Time.deltaTime * speed;
        }
    }
}
