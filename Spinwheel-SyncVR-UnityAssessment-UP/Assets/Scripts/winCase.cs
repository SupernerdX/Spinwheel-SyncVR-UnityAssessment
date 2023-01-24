using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class winCase : MonoBehaviour
{
    private float displayScore;
    public float transitionSpeed = 100;
    public Text scoreText;
    public static int points;
    public scaleFromMicrophone Loudness_script;

    
    
    // Start is called before the first frame update
    void Start()
    {
        
        points = 0;
      
    }

    // Update is called once per frame
    void Update()
    {
        if (inputMethod.keyboardMode == true)
        {
        displayScore = Mathf.MoveTowards(displayScore, points, transitionSpeed * Time.deltaTime);

        //add points for blowing (ran into complications with too drastic fluctuations in mic value)

        /* float pointsF = Loudness_script.loudness; 
        points += (int)pointsF / 10; */

        updateScoreDisplay();

        //Checks to see if the player wins and if this is the case transitions to the win screen
        if(points == 50)
        {
            points = 50;
            WindObstacle.windStrength = 0;
            SceneManager.LoadScene(2);

        }
        //Checks to see if the player loses and if this is the case transitions to the lose screen
        else if (points < 0)
        {
            WindObstacle.windStrength = 0;
            scaleWithRotation.scaleValue = 0.0f;
        SceneManager.LoadScene(3);
     
        }


        }
        
             
    }    

    //Updates the score in the canvas
    public void updateScoreDisplay()
    {
        scoreText.text = string.Format("Score: {0:000}", displayScore);
    }


}
