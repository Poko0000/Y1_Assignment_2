using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{
    private TextMeshProUGUI tmpUI;
    private GameManager gm;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManeger").GetComponent<GameManager>();
        tmpUI = GetComponent<TextMeshProUGUI>();
        tmpUI.text = "Depth: ";
    }

    // Update is called once per frame
    void Update()
    {
        if (gm.OnGame)
        {
            Timer();
        }
       
    }

    private void Timer()
    {
        time += 10 * Time.deltaTime;
        tmpUI.text = "Depth: " + time.ToString("0");
    }
}
