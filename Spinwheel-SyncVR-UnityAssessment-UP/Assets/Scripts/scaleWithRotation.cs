using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class scaleWithRotation : MonoBehaviour
{

public float rotation = 0;
public static float scaleValue = 0.0f;
//public AudioSource growSound;
//public AudioClip growClip;
public float timeBetweensound = 0.25f;
float timer;


    // Start is called before the first frame update
    void Start()
    {
       // growSound = GetComponent<AudioSource>();
       if (inputMethod.keyboardMode == true)
        {
       InvokeRepeating("windSubtraction", 5.0f, 0.4f);
        }
    }

     //Update is called once per frame
    void Update()
    {

      

           //checks to see if the space key is pressed, and if this is the case increases the point anc rotation varibles by 1.
         if (Input.GetKeyDown(KeyCode.Space))
        {
            rotation += 1;
            winCase.points += 1;
            scaleValue += 0.01f;
        }    

//atempt at repeating sound effect
    /*  timer += Time.deltaTime;
        if (timer > timeBetweensound)
        {
            growSound.Play();
            timer = 0;
        } */
       
        transform.Rotate(0,0, 10 * rotation * Time.deltaTime);
       // Debug.Log(winCase.points);
    
    }

     void windSubtraction()
    {
        
        winCase.points += WindObstacle.windStrength;
        scaleValue -= 0.01f;
    
    }
}
