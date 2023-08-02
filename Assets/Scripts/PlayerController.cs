using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform centre;
    public float rotationSpeed;

    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float rotationX = Input.GetAxis("Mouse X") * -rotationSpeed;
        transform.RotateAround(centre.position, Vector3.up, rotationX);
    }
}
