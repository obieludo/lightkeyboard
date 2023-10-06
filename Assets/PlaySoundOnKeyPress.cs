using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnKeyPress : MonoBehaviour
{
    public AudioSource QKeyClip;
    public AudioSource WKeyClip;
    public AudioSource EKeyClip;
    public AudioSource RKeyClip;
    public AudioSource TKeyClip;
    public AudioSource YKeyClip;
    public AudioSource UKeyClip;
    public AudioSource IKeyClip;
    public AudioSource OKeyClip;


        // Update is called once per frame
        void Update()
    {
        //First Key - A
        if (Input.GetKeyDown(KeyCode.Q))
        {
            QKeyClip.Play();
        }

        //Second Key - W
        if (Input.GetKeyDown(KeyCode.W))
        {
            WKeyClip.Play();
        }

        //Third Key - E
        if (Input.GetKeyDown(KeyCode.E))
        {
            EKeyClip.Play();
        }

        //Fourth Key - R
        if (Input.GetKeyDown(KeyCode.R))
        {
            RKeyClip.Play();
        }

        //Fifth Key - T
        if (Input.GetKeyDown(KeyCode.T))
        {
            TKeyClip.Play();
        }

        //Sixth Key - Y
        if (Input.GetKeyDown(KeyCode.Y))
        {
            YKeyClip.Play();
        }

        //Seventh Key - U
        if (Input.GetKeyDown(KeyCode.U))
        {
            UKeyClip.Play();
        }
        
        //Eigth Key - I
        if (Input.GetKeyDown(KeyCode.I))
        {
            IKeyClip.Play();
        }

        //Ninth Key - O
        if (Input.GetKeyDown(KeyCode.O))
        {
            OKeyClip.Play();
        }

    }
}
