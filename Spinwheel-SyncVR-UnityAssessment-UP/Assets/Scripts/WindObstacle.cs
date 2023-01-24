using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindObstacle : MonoBehaviour
{
    public static int windStrength;

    // Start is called before the first frame update
    void Start()
    {
      windStrength = -1;
    }

    // Rotates the pinwheel in the oppiste direction based on windStrength
    void Update()
    {
       transform.Rotate(0,0, windStrength * 20 * Time.deltaTime);
    }
}
