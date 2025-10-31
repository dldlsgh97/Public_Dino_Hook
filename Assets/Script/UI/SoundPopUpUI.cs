using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundPopUpUI : MonoBehaviour
{
    [SerializeField]
    private Slider MasterVolumeSlider;
    [SerializeField]
    private Slider BGMVolumeSlider;
    [SerializeField]
    private Slider SFXVolumeSlider;
    void OnEnable()
    {
        SoundManager.Instance.MasterVolumeSlider = MasterVolumeSlider;
        SoundManager.Instance.BgmVolumeSlider = BGMVolumeSlider;
        SoundManager.Instance.SfxVolumeSlider = SFXVolumeSlider;

        MasterVolumeSlider.value = SoundManager.Instance.MasterVolume;
        BGMVolumeSlider.value = SoundManager.Instance.BgmVolume;
        SFXVolumeSlider.value = SoundManager.Instance.SfxVolume;
    }
    public void SetMasterVolume(float volume)
    {
        SoundManager.Instance.SetMasterVolume(volume);
    }
    public void SetBGMVolume(float volume)
    {
        SoundManager.Instance.SetBGMVolume(volume);
    }
    public void SetSFXVolume(float volume)
    {
        SoundManager.Instance.SetSFXVolume(volume);
    }
}
