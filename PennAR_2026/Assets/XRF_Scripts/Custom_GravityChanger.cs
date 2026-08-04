using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Custom_GravityChanger : MonoBehaviour
{


    public void Button_GravityZero()
    {
        Physics.gravity = new Vector3(0,0,0);
    }
    public void Button_GravityDown()
    {
        Physics.gravity = new Vector3(0, -9.8f, 0);

    }
    public void Button_GravityUp()
    {
        Physics.gravity = new Vector3(0, 9.8f, 0);

    }
    public void Button_GravityLeft()
    {
        Physics.gravity = new Vector3(-9.8f,0, 0);

    }
    public void Button_GravityRight()
    {
        Physics.gravity = new Vector3(9.8f, 0, 0);

    }
    public void Button_GravityForward()
    {
        Physics.gravity = new Vector3(0, 0, 9.8f);

    }
    public void Button_GravityBackward()
    {
        Physics.gravity = new Vector3(0, 0, -9.8f);
    }
}
