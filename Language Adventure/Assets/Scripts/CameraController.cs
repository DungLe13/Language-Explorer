using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public float turnSpeed = 5;
    public GameObject player;
    private Vector3 offset;

    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;
        //offset = new Vector3(player.transform.position.x - 5, player.transform.position.y + 3, player.transform.position.z + 10);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //offset = Quaternion.AngleAxis(Input.GetAxisRaw("Horizontal") * turnSpeed, Vector3.up) * offset;
        transform.position = player.transform.position + offset;
        //transform.LookAt(player.transform.position);
    }
}
