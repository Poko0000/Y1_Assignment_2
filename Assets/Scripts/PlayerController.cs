using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform centre;
    public float rotationSpeed;

    private Rigidbody playerRb;
    private bool speedUp;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

        if (Input.GetKey(KeyCode.Space))
        {
            Time.timeScale = 2;
            speedUp = true;
        }
        else
        {
            Time.timeScale = 1;
            speedUp = false;
        }
    }

    void PlayerMovement()
    {
        float rotationX = Input.GetAxis("Mouse X") * -rotationSpeed;
        playerRb.transform.RotateAround(centre.position, Vector3.up, rotationX);       
    }
}
