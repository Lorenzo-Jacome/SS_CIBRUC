using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    private static readonly string FirstPlay = "FirstPlay";   
    private static readonly string MusicPref = "MusicPref";  
    private static readonly string EnvPref = "EnvPref";  
    private static readonly string FxPref = "FxPref";  
    private int firstPlayInt;
    public Slider music,fx,env;
    private float musicFloat,fxFloat,envFloat;

    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(MusicPref,music.value);
        PlayerPrefs.SetFloat(FxPref,fx.value);
        PlayerPrefs.SetFloat(EnvPref,env.value);
    }
    void Start()
    {
        firstPlayInt=PlayerPrefs.GetInt(FirstPlay);

        if(firstPlayInt==0)
        {
            musicFloat=1f;
            fxFloat=1f;
            envFloat=1f;
            music.value=musicFloat;
            fx.value=fxFloat;
            env.value=envFloat;
            PlayerPrefs.SetFloat(MusicPref, musicFloat);
            PlayerPrefs.SetFloat(FxPref,fxFloat);
            PlayerPrefs.SetFloat(EnvPref,envFloat);
            PlayerPrefs.SetInt(FirstPlay,-1);
        }
        else
        {
            musicFloat=PlayerPrefs.GetFloat(MusicPref);
            music.value=musicFloat;
            fxFloat=PlayerPrefs.GetFloat(FxPref);
            fx.value=fxFloat;
            envFloat=PlayerPrefs.GetFloat(EnvPref);
            env.value=envFloat;
        }

    }
    void OnApplicationFocus(bool inFocus)
    {
        if(!inFocus)
        {
            SaveSoundSettings();
        }
    }

}
