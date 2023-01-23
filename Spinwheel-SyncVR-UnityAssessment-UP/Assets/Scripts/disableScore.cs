using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disableScore : MonoBehaviour
{
    public static bool isScoring = false;

    public Text blowingInstructions;

    public GameObject scorePannel;


    // Update is called once per frame
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
        //Time.timeScale = 1f;
        blowingInstructions.text = "Blow into your microphone to spin the pinwheel!";
      
    }

    public void activateScore()
    {
        scorePannel.SetActive(true);
        //Time.timeScale = 0f;
          blowingInstructions.text = " ";
       
    }
}
