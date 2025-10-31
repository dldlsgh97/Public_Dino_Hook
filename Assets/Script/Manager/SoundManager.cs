using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    private AudioMixer mixer;
    [SerializeField] 
    private AudioMixerGroup bgmMix;
    [SerializeField] 
    private AudioMixerGroup sfxMix;
    [SerializeField] 
    private AudioMixerGroup masterMix;

    public Slider MasterVolumeSlider;
    public Slider BgmVolumeSlider;
    public Slider SfxVolumeSlider;

    public float MasterVolume = 0.5f;
    public float BgmVolume = 0.5f;
    public float SfxVolume = 0.5f;

    [SerializeField]
    private AudioSource[] bgmPlayer;
    [SerializeField]
    private AudioSource[] sfxPlayer;
    [SerializeField]
    private AudioClip[] bgmClip;


    public static SoundManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        PlayBGM(bgmClip[0]);
    }
    public void SetMasterVolume(float volume)
    {
        float db = Mathf.Lerp(-20f, 10f, volume);
        if (volume > MasterVolumeSlider.minValue)
        {
            mixer.SetFloat("Master", db);
        }
        else
        {
            mixer.SetFloat("Master", -80);
        }
        MasterVolume = volume;
    }
    public void SetBGMVolume(float volume)
    {
        float db = Mathf.Lerp(-20f, 10f, volume);
        if (volume > BgmVolumeSlider.minValue)
        {
            mixer.SetFloat("BGM", db);
        }
        else
        {
            mixer.SetFloat("BGM", -80);
        }
        BgmVolume = volume;
    }
    public void SetSFXVolume(float volume)
    {
        float db = Mathf.Lerp(-20f, 10f, volume);
        if (volume > SfxVolumeSlider.minValue)
        {
            mixer.SetFloat("SFX", db);
        }
        else
        {
            mixer.SetFloat("SFX", -80);
        }
        SfxVolume = volume;
    }
    public void PlayBGM(AudioClip clip)
    {
        bgmPlayer[0].clip = bgmClip[0];
        bgmPlayer[0].loop = true;
        bgmPlayer[0].Play();
    }
    public void PlaySfx(AudioClip clip)
    {
        sfxPlayer[0].clip = clip;
        sfxPlayer[0].PlayOneShot(clip);
    }
}
