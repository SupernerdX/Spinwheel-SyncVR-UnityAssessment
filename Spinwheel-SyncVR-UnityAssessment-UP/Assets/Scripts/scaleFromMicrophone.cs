using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleFromMicrophone : MonoBehaviour
{

 
    public AudioLoudnessDetection detector;
    public float loudnessSense = 100;
    public float threshold = 0.1f;
    public float loudness = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Detects how loud your microphon is and assigns it a value to be used later in the project.
    void Update()
    {
   
        loudness = detector.GetLoundnessFromMicrophone() * loudnessSense;
        //print(loudness);

        if(loudness >= threshold)
            transform.Rotate(0,0, loudness * 5 * Time.deltaTime);

        //lerp value from minimum scale to max scale depening on loudness
        //transform.localRotation = Quaternion.Euler(0, 0, loudness);


        
    }
}
