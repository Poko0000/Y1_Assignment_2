using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Obstacles;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObstaacles());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnObstaacles()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            
            Instantiate(Obstacles, new Vector3(RandomNum(), 0, RandomNum()), Quaternion.identity);
        }
    }



    float RandomNum()
    {
        float index = Random.Range(1, 10) / 10.0f;
        return index;
    }
}
