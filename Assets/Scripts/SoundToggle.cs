using UnityEngine;
using UnityEngine.UI;

public class SoundToggle : MonoBehaviour
{
    [field: SerializeField] public ButtonClickHandler ButtonClickHandler { get; private set; }
    [field: SerializeField] public VolumeController VolumeController { get; private set; }
    [field: SerializeField] public Slider Slider { get; private set; }

    private void Awake()
    {
        ButtonClickHandler.OnButtonPressed += ToggleAllSoundsPlayback;
    }

    private void OnDestroy()
    {
        ButtonClickHandler.OnButtonPressed -= ToggleAllSoundsPlayback;
    }

    public void ToggleAllSoundsPlayback()
    {
        if (Slider.value > VolumeController.VolumeOffValue)
        {
            VolumeController.TurnOffSound();
        }
        else
        {
            VolumeController.TurnOnSound();
        }
    }
}