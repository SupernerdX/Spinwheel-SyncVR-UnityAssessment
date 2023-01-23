using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class scenechanger : MonoBehaviour
{
     public void mainMenu()
   {
        SceneManager.LoadScene(0);
        
   }
   public void startGame()
   {
        SceneManager.LoadScene(1);

   }

   public void winScreen()
   {
        SceneManager.LoadScene(1);

   }

   public void loseScreen()
   {

    SceneManager.LoadScene(3);
   }

    public void QuitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }

   
}
