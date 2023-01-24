using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disableScore : MonoBehaviour
{
    public static bool isScoring = false;

    public GameObject freePlayPanel;

    public GameObject scorePannel;


    // checks to see if blowing mode is on and if so disables and enables the needed panels accordingly.
    void Update()
    {
       
            if (ActivateAndDeactivate.isBlowing == true)
            {
                disScore();
               
            }
            else if(ActivateAndDeactivate.isBlowing == false)
            {
                activateScore();
            }   
       

    }

    public void disScore()
    {
        scorePannel.SetActive(false);
        freePlayPanel.SetActive(true);
       
      
    }

    public void activateScore()
    {
        scorePannel.SetActive(true);
        freePlayPanel.SetActive(false);

         
       
    }
}
