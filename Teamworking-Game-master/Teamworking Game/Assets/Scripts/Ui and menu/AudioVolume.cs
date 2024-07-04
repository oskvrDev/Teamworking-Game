using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioVolume : MonoBehaviour
{
    //store audio mixer and sliders for changing volume
    [SerializeField]
    AudioMixer audioMixer;
    [SerializeField]
    Slider soundEffectsVolume;
    [SerializeField]
    Slider musicVolume;

    public void SetSoundEffectsVolume(float volume)
    {
        //set the sound effects sound volume using slider value
        audioMixer.SetFloat("soundEffectsVolume", volume);
    }

    public void SetMusicVolume(float volume)
    {
        //set the music volume using slider value
        audioMixer.SetFloat("musicVolume", volume);
    }

    private void Start()
    {
        //get the value of audio mixer and set slider value when loading new scene
        float mixerVolume;
        audioMixer.GetFloat("soundEffectsVolume", out mixerVolume);
        soundEffectsVolume.value = mixerVolume;

        audioMixer.GetFloat("musicVolume", out mixerVolume);
        musicVolume.value = mixerVolume;
    }
}
