using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnKeyPress : MonoBehaviour
{
    public AudioSource AKeyClip;
    public AudioSource SKeyClip;
    public AudioSource DKeyClip;
    public AudioSource FKeyClip;
    public AudioSource GKeyClip;
    public AudioSource HKeyClip;
    public AudioSource JKeyClip;
    public AudioSource KKeyClip;
    public AudioSource LKeyClip;

    // Update is called once per frame
    void Update()
    {
        //First Key - A
        if (Input.GetKeyDown(KeyCode.A))
        {
            AKeyClip.Play();
        }

        //Second Key - S
        if (Input.GetKeyDown(KeyCode.S))
        {
            SKeyClip.Play();
        }

        //Third Key - D
        if (Input.GetKeyDown(KeyCode.D))
        {
            DKeyClip.Play();
        }

        //Fourth Key - F
        if (Input.GetKeyDown(KeyCode.F))
        {
            FKeyClip.Play();
        }

        //Fifth Key - G
        if (Input.GetKeyDown(KeyCode.G))
        {
            GKeyClip.Play();
        }

        //Sixth Key - H
        if (Input.GetKeyDown(KeyCode.H))
        {
            HKeyClip.Play();
        }

        //Seventh Key - J
        if (Input.GetKeyDown(KeyCode.J))
        {
            JKeyClip.Play();
        }
        
        //Eigth Key - K
        if (Input.GetKeyDown(KeyCode.K))
        {
            KKeyClip.Play();
        }

        //Ninth Key - L
        if (Input.GetKeyDown(KeyCode.L))
        {
            LKeyClip.Play();
        }

    }
}
