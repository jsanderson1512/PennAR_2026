using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Custom_DecisionOutcomes : MonoBehaviour
{
    public bool nervous = false;
    public bool fresh = false;
    public bool goodSound = false;


    public GameObject[] Success_Objects;
    public GameObject[] Mediocre_Objects;
    public GameObject[] Bad_Objects;


    // Start is called before the first frame update
    void Start()
    {
        UpdateOutcomes();

    }

    public void TurnOffAllObjects()
    {
        if(Success_Objects!=null)
            ChangeObjectState(Success_Objects, false);
        if (Mediocre_Objects != null)
            ChangeObjectState(Mediocre_Objects, false);
        if (Bad_Objects != null)
            ChangeObjectState(Bad_Objects, false);
    }

    public void ChangeObjectState(GameObject[] objectList, bool state)
    {
        if (objectList != null)
        {
            foreach (GameObject obj in objectList)
            {
                obj.SetActive(state);
            }
        }
    }
    

    public void Button_Decision1()
    {
        nervous = true;
        UpdateOutcomes();

    }
    public void Button_Decision2()
    {
        fresh = true;
        UpdateOutcomes();

    }
    public void Button_Decision3()
    {
        goodSound = true;
        UpdateOutcomes();

    }





    public void UpdateOutcomes()
    {
        //success
        //medicore
        //bad

        if (nervous == false && fresh == false && goodSound == false)
        {
            Bad();
        }
        if (nervous == false && fresh == true && goodSound == false)
        {
            Bad();
        }
        if (nervous == false && fresh == true && goodSound == true)
        {
            Success();
        }
        if (nervous == false && fresh == false && goodSound == true)
        {
            Mediocre();
        }


        if (nervous == true && fresh == false && goodSound == false)
        {
            Bad();
        }
        if (nervous == true && fresh == true && goodSound == false)
        {
            Bad();
        }
        if (nervous == true && fresh == true && goodSound == true)
        {
            Success();
        }
        if (nervous == true && fresh == false && goodSound == true)
        {
            Mediocre();
        }


    }

    public void Success()
    {
        ChangeObjectState(Success_Objects, true);
        ChangeObjectState(Mediocre_Objects, false);
        ChangeObjectState(Bad_Objects, false);

    }
    public void Mediocre()
    {
        ChangeObjectState(Success_Objects, false);
        ChangeObjectState(Mediocre_Objects, true);
        ChangeObjectState(Bad_Objects, false);

    }
    public void Bad()
    {
        ChangeObjectState(Success_Objects, false);
        ChangeObjectState(Mediocre_Objects, false);
        ChangeObjectState(Bad_Objects, true);

    }
}
