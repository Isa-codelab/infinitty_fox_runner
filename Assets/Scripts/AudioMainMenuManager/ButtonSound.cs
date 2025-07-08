using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioClip sound;
    public AudioSource audiosource;

    public void Onbuttonclick()
    {
        audiosource.PlayOneShot(sound);
    }
   
}
