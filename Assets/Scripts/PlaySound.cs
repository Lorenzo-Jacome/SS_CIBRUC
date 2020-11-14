using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    // Start is called before the first frame update
public AudioSource sound;
public AudioClip clip ;
  
  public void playSoundDown(){
      sound.PlayOneShot (clip);
  }
}
