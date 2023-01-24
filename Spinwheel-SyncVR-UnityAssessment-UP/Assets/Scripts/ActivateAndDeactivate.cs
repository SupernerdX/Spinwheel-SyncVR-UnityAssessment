using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAndDeactivate : MonoBehaviour
{
    public scaleFromMicrophone scaleFromMicrophone;
    public winCase winCase;
     public static bool  isBlowing = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // disables the script if blowing mode is off.
    void Update()
    {
        if (isBlowing == false)
        {
            scaleFromMicrophone.enabled = false;
        }
        
     }
       
}
