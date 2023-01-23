
using UnityEngine;

public class dontDestroy : MonoBehaviour
{

   // Makes sure the Music isnt Destroyed when transitioning scenes 
   private static dontDestroy dontDestroyInstance;

    void Awake()
    {
        DontDestroyOnLoad(this); 

        if(dontDestroyInstance == null)
        {
            dontDestroyInstance = this;
        }

        else
        {
            Destroy(gameObject); 

        }

    }
}
