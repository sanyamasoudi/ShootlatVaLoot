using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteAndUnMuteController : MonoBehaviour
{
    public static MuteAndUnMuteController instance;
    public bool IsMute;
    void Awake()
    {
        instance=this;
        IsMute=false;
    }
    public void Mute()
    {
        IsMute=true;
        GameObject.Find("Main Camera").GetComponent<AudioSource>().mute=true;
    }
    public void UnMute()
    {
        IsMute=false;
        GameObject.Find("Main Camera").GetComponent<AudioSource>().mute=false;
    }
}
