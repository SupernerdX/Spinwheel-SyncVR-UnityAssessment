using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class scenechanger : MonoBehaviour
{
     //Opens the main menu
     public void mainMenu()
   {
        SceneManager.LoadScene(0);
        
   }
   //Opens the game
   public void startGame()
   {
        SceneManager.LoadScene(1);

   }
     //Shows the win screen
   public void winScreen()
   {
        SceneManager.LoadScene(1);

   }
     //Shows the lose screen
   public void loseScreen()
   {

    SceneManager.LoadScene(3);
   }

     //Quits game
    public void QuitGame()
    {
        Debug.Log("Quitting Game");
        Application.Quit();
    }

   
}
