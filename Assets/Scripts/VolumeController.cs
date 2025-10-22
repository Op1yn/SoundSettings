using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    [SerializeField] private string _nameVolume;

    [field: SerializeField] public AudioMixerGroup Mixer { get; private set; }
    [field: SerializeField] public Slider Slider { get; private set; }

    private float _volumeLevelBeforeTurningOff = 1f;
    private int _soundMultiplier = 20;

    public float VolumeOffValue { get; private set; } = 0.001f;

    private void Awake()
    {
        Slider.onValueChanged.AddListener(CangeVolume);
    }

    public void CangeVolume(float volume)
    {
        Mixer.audioMixer.SetFloat(_nameVolume, Mathf.Log10(volume) * _soundMultiplier);
    }

    public void TurnOffSound()
    {
        _volumeLevelBeforeTurningOff = Slider.value;
        Slider.value = VolumeOffValue;
    }

    public void TurnOnSound()
    {
        Slider.value = _volumeLevelBeforeTurningOff;
    }
}
