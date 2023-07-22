using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{

    public AudioMixer mixer;

    public void BGMSetLevel(float sliderVal)
    {
        mixer.SetFloat("BackGroundMusic", Mathf.Log10(sliderVal) * 20);
    }

    public void SFXSetLevel(float sliderVal)
    {
        mixer.SetFloat("SoundEffect", Mathf.Log10(sliderVal) * 20);
    }
}
