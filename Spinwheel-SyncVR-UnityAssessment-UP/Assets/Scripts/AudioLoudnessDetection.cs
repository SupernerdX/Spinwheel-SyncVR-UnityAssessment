using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLoudnessDetection : MonoBehaviour
{
    public int BeforeClipData = 64;
    private AudioClip microphoneClip;
    // Start is called before the first frame update
    void Start()
    {
        MicrophoneToClip();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MicrophoneToClip()
    {
        //gets the first microphone in device list
    string microphoneName = Microphone.devices[0];
    microphoneClip = Microphone.Start(microphoneName, true, 20, AudioSettings.outputSampleRate);
    }

    public float GetLoundnessFromMicrophone()
    {
    return GetLoundnessFromClip(Microphone.GetPosition(Microphone.devices[0]), microphoneClip);
    }


    public float GetLoundnessFromClip(int clipPos, AudioClip clip)
    {
        //Gets loudness data from clip

        int startPostion = clipPos - BeforeClipData;

        if(startPostion < 0)
            return 0;

        float[] waveData = new float[BeforeClipData];
        clip.GetData(waveData, startPostion);

        //Measure loudness
        float totalClipLoudness = 0;

        for (int i = 0; i < BeforeClipData; i++)
        {
            totalClipLoudness += Mathf.Abs(waveData[i]);
        
        }

        return totalClipLoudness / BeforeClipData;






    }
}
