using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Zombies_Idle : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] sounds;
    void Start()
    {
        //audioSource=gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!audioSource.isPlaying)
    {
      soundLoop();
    }
    }

    void soundLoop(){
      audioSource.clip = sounds[Random.Range(0,sounds.Length)];
      audioSource.PlayDelayed(1);
      Debug.Log(audioSource.clip.ToString());
    }


}
