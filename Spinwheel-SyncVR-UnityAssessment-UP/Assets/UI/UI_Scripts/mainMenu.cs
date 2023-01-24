using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{

//used for changing between scenes
   public void playGame()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    Debug.Log("This Game Plays");


   }

   public void QuitGame()
    {
        Debug.Log("Quitting Game"); 
        Application.Quit();
    }

    public void MainReturn()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("Return to Main Menu");
    }
}
