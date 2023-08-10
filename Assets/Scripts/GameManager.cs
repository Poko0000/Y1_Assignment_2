using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject bomb;
    
    private float time;
    private int time1;
    private float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        time1 = 0;
        StartCoroutine(SpawnObstaacles(speed));
        StartCoroutine("BombSwan");
    }

    private void Update()
    {
        Timer();
    }

    IEnumerator SpawnObstaacles(float time)
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            SwawnTimes();
        }
    }

    IEnumerator BombSwan()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            Instantiate(bomb, new Vector3(RandomNum(), 3, RandomNum()), Quaternion.identity);
        }
       
    }

    void SwawnTimes()
    {      
        for (int i = 0; i < time1; i++)
        {
            Instantiator();
        }     
    }

    void Instantiator()
    {
        Instantiate(obstacle, new Vector3(RandomNum(), 0, RandomNum()), Quaternion.identity);
    }

    float RandomNum()
    {
        float index = Random.Range(-10, 10) / 10.0f;

        if (index == 0)
        {
            index = 1f;
        }
        return index;
    }

    void Timer()
    {
        time += Time.deltaTime;
        time1 = (int)time / 10;

        if (time1 < 1)
        {
            time1 = 1;
        }

        else if (time1 >= 20)
        {
            time1 = 20;
        }
    }
}
