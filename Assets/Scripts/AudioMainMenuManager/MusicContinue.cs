using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicContinue : MonoBehaviour
{
    public AudioSource audioSourceToplay;
    private static MusicContinue instance;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
