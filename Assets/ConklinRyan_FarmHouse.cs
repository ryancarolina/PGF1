using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConklinRyan_FarmHouse : MonoBehaviour {

    string checkCar = "check the car";
    string checkFarmhouse = "check the farmhouse";
    string enterFarmhouse = "enter the farmhouse";
    string breakWindow = "break the window";
    string findHighway = "find a highway";
    string tryPhone = "try the phone";
    string inspectBasement = "inspect the basement";

    //string playerName = " ";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to Ryan's Text Game!");
    }

    [SerializeField]
    string currHeading = "Wake Up";
    [SerializeField]
    string playerName = "Player";
    // Update is called once per frame
    void Update()
    {
        string tempHeading = currHeading.ToLower();

        if (tempHeading == "wake up")
        {
            Debug.Log("You wake up, hazy... it takes a second to remember your own name. **ENTER YOUR NAME**");

            if (playerName != "Player")
            {
                if (playerName != null)
                {
                    Debug.Log("Hello " + playerName + " Do you " + checkCar + " or " + checkFarmhouse + "?");
                }
            }
        }
        else if (tempHeading == "check the car")
        {
            Debug.Log("You check the car... do you " + breakWindow + " or " + checkFarmhouse + "?");
        }
        else if (tempHeading == "break the window")
        {
            Debug.Log("You break the window... do you " + findHighway + " or " + checkFarmhouse + "?");
        }
        else if (tempHeading == "find a highway")
        {
            Debug.Log("Your hunt to find a highway worked... you have survived the farmhouse killer! You win!");
        }
        else if (tempHeading == "check the farmhouse")
        {
            Debug.Log("You check the farmhouse... do you " + checkCar + " or " + enterFarmhouse + "?");
        }
        else if (tempHeading == "enter the farmhouse")
        {
            Debug.Log("You check the farmhouse... do you " + tryPhone + " or " + inspectBasement + "?");
        }
        else if (tempHeading == "try the phone")
        {
            Debug.Log("You try the phone... do you " + inspectBasement + " or " + findHighway + "?");
        }
        else if (tempHeading == "inspect the basement")
        {
            Debug.Log("You inspect the basement ... you are murder-killed by Bo the farmhouse killer and lose the game!");
        }
        else
        {
            Debug.Log("Unknown heading: \"" + currHeading + "\"");
        }
        
    }
}
