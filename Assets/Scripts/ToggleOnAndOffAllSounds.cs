using UnityEngine;

public class ToggleOnAndOffAllSounds : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Toggle _toggle;
    [SerializeField] private AudioListener _listener;

    private void Start()
    {
        _toggle.onValueChanged.AddListener(ToggleAllSounds);
    }

    private void OnDisable()
    {
        _toggle.onValueChanged.RemoveListener(ToggleAllSounds);
    }

    private void ToggleAllSounds(bool value)
    {
        _listener.enabled = value;
    }
}
