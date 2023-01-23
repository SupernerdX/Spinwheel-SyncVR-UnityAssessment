using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputMethod : MonoBehaviour
{
    public static bool keyboardMode;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       

    }

   public void isBlowing()
   {
    ActivateAndDeactivate.isBlowing = true;
    keyboardMode = false;
    

   }

   public void isNotBlowing()
   {
    ActivateAndDeactivate.isBlowing = false;
    keyboardMode = true;


   }
}
