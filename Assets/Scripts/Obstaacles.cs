using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaacles : MonoBehaviour
{
    private GameObject centre;
    private float moveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        centre = GameObject.Find("Center");
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(0.002f, 0.002f, 0.002f);
        transform.Translate((transform.position - centre.transform.position).normalized * moveSpeed * Time.deltaTime);
        Destroy(gameObject, 3f);
    }

}
