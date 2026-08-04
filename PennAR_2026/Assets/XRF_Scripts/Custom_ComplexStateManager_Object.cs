using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static XRF_UPenn_InteractionController;

public class Custom_ComplexStateManager_Object : MonoBehaviour
{
    public enum MyObjectStates // your custom enumeration
    {
        Initial,
        Tilled,
        Watered,
        Growing,
        Mature
    };
    public MyObjectStates currentState; // this public var should appear as a drop down

    public bool iWasClicked;

    // Start is called before the first frame update
    void Start()
    {
        currentState = MyObjectStates.Initial;  // this public var should appear as a drop down
        InitializeNextState();
    }

    public void Button_DoClick()
    {
        iWasClicked = true;
    }


    public void GoToNextState()
    {
        if(currentState == MyObjectStates.Initial)
        {
            currentState = MyObjectStates.Tilled;
            InitializeNextState();
        }
        else if (currentState == MyObjectStates.Tilled)
        {
            currentState = MyObjectStates.Watered;
            InitializeNextState();
        }
        else if (currentState == MyObjectStates.Watered)
        {
            currentState = MyObjectStates.Growing;
            InitializeNextState();
        }
        else if (currentState == MyObjectStates.Growing)
        {
            currentState = MyObjectStates.Mature;
            InitializeNextState();
        }
        else if (currentState == MyObjectStates.Mature)
        {
            //does something happen when you interact with all the mature things?
        }
    }

    public void InitializeNextState()
    {
        iWasClicked = false;

        if (currentState == MyObjectStates.Initial)
        {
            //does something happen on start?
        }
        else if (currentState == MyObjectStates.Tilled)
        {
            //does something happen on next?
            //for example, a gameobject gets switched?

        }
        else if (currentState == MyObjectStates.Watered)
        {        
            //does something happen on next?
            //for example, a gameobject gets switched?

        }
        else if (currentState == MyObjectStates.Growing)
        {
            //does something happen on next?
            //for example, a gameobject gets switched?
        }
        else if (currentState == MyObjectStates.Mature)
        {
            //does something happen on next?
            //for example, a gameobject gets switched?
        }
    }

}
