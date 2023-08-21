using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaacles : MonoBehaviour
{
    private GameObject centre;
    private float moveSpeed = 8;
    private bool speedUp;

    private GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        centre = GameObject.Find("ObstacleCenter");
        gm = GameObject.Find("GameManeger").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        ObjectsMovement(moveSpeed);
    }

    public void ObjectsMovement(float speed)
    {
        transform.localScale += new Vector3(0.03f, 0.03f, 0.03f);
        transform.Translate((transform.position - centre.transform.position).normalized * speed * Time.deltaTime);
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Player" && speedUp)
        {
            Destroy(gameObject);
            Debug.Log("break");
        }

        if (other.gameObject.name == "Player" && !speedUp)
        {
            gm.GameOver();
            Debug.Log("GameOver");          
        }
    }

}
