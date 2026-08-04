using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Custom_ComplexStateManager_Manager : MonoBehaviour
{
    //this script will allow several sets of interactions to happen
    //if all events from set 1 are achieved, activate set 2, etc.

    private Custom_ComplexStateManager_Object[] allClickers;//this collects all the interactable objects.

    // Start is called before the first frame update
    void Start()
    {
        allClickers = Object.FindObjectsByType<Custom_ComplexStateManager_Object>(FindObjectsSortMode.None);
    }

    // Update is called once per frame
    void Update()
    {
        //check all the things, if any are not done, return to start up update loop
        bool allThingsComplete = true;
        foreach (Custom_ComplexStateManager_Object theClicker in allClickers)
        {
            if (theClicker.iWasClicked == false)
            {
                //if anything is false, make this false;
                allThingsComplete = false;
            }
        }

        //at the end of the check, if everything is done, go to next state
        if (allThingsComplete)
        {
            foreach (Custom_ComplexStateManager_Object theClicker in allClickers)
            {
                theClicker.GoToNextState();
            }
        }
    }





}
