using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource src=null;
    void Awake()
    {
        src=GameObject.Find("Main Camera").GetComponent<AudioSource>();
        src.loop=true;   
    }
    void Start()
    {
        src.PlayOneShot(BirdSelector.instance.Audio);
    }
    void Update()
    {
        if(MuteAndUnMuteController.instance.IsMute)
        {
            src.mute=true;
        }
        else
        {
            src.mute=false;
        }
    }
}
