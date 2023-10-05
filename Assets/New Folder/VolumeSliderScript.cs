using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSliderScript : MonoBehaviour
{
    [SerializeField] private Slider _Slider;

    void Start()
    {
        _Slider.onValueChanged.AddListener(val => SoundManager.Instance.ChangeMasterVolume(val));   
    }

}
