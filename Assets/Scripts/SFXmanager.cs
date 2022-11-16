using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXmanager : MonoBehaviour
{

    private AudioSource _audiosource;

    void Awake()
    {
        _audiosource = GetComponent<AudioSource>();
    }

}
