using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    public string type;

    public void SetLevel(float sliderValue)
    {
        mixer.SetFloat(type,Mathf.Log10(sliderValue)*20);
    }
}
