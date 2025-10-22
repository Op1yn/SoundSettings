using UnityEngine;

public class SoundActivator : MonoBehaviour
{
    [SerializeField] private ButtonClickHandler _bsuttonClickHandler;
    [SerializeField] private AudioSource _audioSource;

    private void Start()
    {
        _bsuttonClickHandler.OnButtonPressed += PlaySound;
    }

    private void OnDestroy()
    {
        _bsuttonClickHandler.OnButtonPressed -= PlaySound;
    }

    private void PlaySound()
    {
        _audioSource.Play();
    }
}
