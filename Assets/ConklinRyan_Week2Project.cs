using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConklinRyan_Week2Project : MonoBehaviour
{
    Text screen;

    // Start is called before the first frame update
    void Start()
    {
        GameObject go = GameObject.Find("MainText");

        if (go)
        {
            screen = go.GetComponent<Text>();

            if (!screen)
            {
                Debug.LogError("Text component was not found on MainText");
            }
        }
        else
        {
            Debug.LogError("GameObject MainText not found!!");
        }

        screen.text = "Hello World!";

    }

    // Update is called once per frame
    void Update()
    {

    }
}
