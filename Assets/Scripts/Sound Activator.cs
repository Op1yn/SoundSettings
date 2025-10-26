using UnityEngine;
using UnityEngine.UI;

public class SoundActivator : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private AudioSource _audioSource;

    private void Start()
    {
        _button.onClick.AddListener(PlaySound);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(PlaySound);
    }

    public void PlaySound()
    {
        _audioSource.Play();
    }
}
