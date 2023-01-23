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

    // Update is called once per frame
    void Update()
    {
        if (isBlowing == false)
        {
            scaleFromMicrophone.enabled = false;
        }
        
     }
       
}
