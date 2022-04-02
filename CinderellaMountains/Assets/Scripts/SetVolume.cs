using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetLevel (float sliderValue)
    {
        // Takes 0.0001 slidervalue and turns it into a value between -80 & 0 on a logarithmic scale.
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
    }
}
