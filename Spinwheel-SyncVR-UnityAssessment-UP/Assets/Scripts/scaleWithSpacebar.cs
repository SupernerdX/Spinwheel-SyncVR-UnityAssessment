using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleWithSpacebar : MonoBehaviour
{
    public Vector3 minScale;
    public Vector3 maxScale;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Scales the pinwheel based on howmany times the spacebar is pressed.
         transform.localScale = Vector3.Lerp(minScale, maxScale, scaleWithRotation.scaleValue);
         
       
        
    }
}
