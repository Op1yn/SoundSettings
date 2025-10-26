using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeAdjuster : MonoBehaviour
{
    [SerializeField] private string _nameVolume;

    [field: SerializeField] public AudioMixerGroup Mixer { get; private set; }
    [field: SerializeField] public Slider Slider { get; private set; }

    private int _soundMultiplier = 20;

    private void Awake()
    {
        Slider.onValueChanged.AddListener(CangeVolume);
    }

    public void CangeVolume(float volume)
    {
        Mixer.audioMixer.SetFloat(_nameVolume, Mathf.Log10(volume) * _soundMultiplier);
    }
}
