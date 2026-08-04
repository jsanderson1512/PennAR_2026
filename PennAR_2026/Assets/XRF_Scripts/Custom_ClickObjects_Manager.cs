using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Custom_ClickObjects_Manager : MonoBehaviour
{
    private Custom_ClickObjects_Clicker[] allClickers;

    private bool iWonTheGame;

    public GameObject theReward;

    // Start is called before the first frame update
    void Start()
    {
        allClickers = Object.FindObjectsByType<Custom_ClickObjects_Clicker>(FindObjectsSortMode.None);

        iWonTheGame = false;
        theReward.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(iWonTheGame)
        {

        }
        else
        {
            //check all the things, if any are not done, return to start up update loop
            foreach (Custom_ClickObjects_Clicker theClicker in allClickers)
            {
                if (theClicker.iWasClicked == false)
                {
                    return;
                }
            }

            iWonTheGame=true;
            theReward.SetActive(true);

        }


    }
}
