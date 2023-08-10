using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private GameObject centre;
    private float moveSpeed = 6;
    // Start is called before the first frame update
    void Start()
    {
        centre = GameObject.Find("Center");
    }

    // Update is called once per frame
    void Update()
    {
        ObjectsMovement(moveSpeed);
    }

    public void ObjectsMovement(float speed)
    {
        transform.Translate((transform.position - centre.transform.position).normalized * speed * Time.deltaTime);
        Destroy(gameObject, 5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
            foreach (GameObject obstacle in obstacles)
            { 
                Destroy(obstacle); 
            }
            Destroy(gameObject);
        }

    }
}
