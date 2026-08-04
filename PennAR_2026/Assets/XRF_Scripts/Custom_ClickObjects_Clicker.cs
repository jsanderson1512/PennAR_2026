using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Custom_ClickObjects_Clicker : MonoBehaviour
{
    public bool iWasClicked;

    // Start is called before the first frame update
    void Start()
    {
        iWasClicked = false;
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Button_DoClick()
    {
        iWasClicked = true;
    }

}
