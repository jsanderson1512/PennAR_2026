using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Custom_SeriesOfTriggers : MonoBehaviour
{
    public int levelToTurnOn = 0;
    public GameObject[] allOfTheLevels;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < allOfTheLevels.Length; i++)
        {
            if (i == 0)
            {
                allOfTheLevels[i].SetActive(true);
            }
            else
            {
                allOfTheLevels[i].SetActive(false);

            }

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }




    public void Button_DoTheTrigger()
    {

        for (int i = 0; i < allOfTheLevels.Length; i++)
        {
            if (i == levelToTurnOn)
            {
                allOfTheLevels[i].SetActive(true);
            }
            else
            {
                allOfTheLevels[i].SetActive(false);

            }

        }
    }
}
