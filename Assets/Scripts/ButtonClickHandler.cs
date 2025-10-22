using UnityEngine;

public class ButtonClickHandler : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Button _button;

    public event System.Action OnButtonPressed;

    private void Start()
    {
        _button.onClick.AddListener(OnButtonClick);
    }

    private void OnDestroy()
    {
        _button.onClick.RemoveAllListeners();
    }

    private void OnButtonClick()
    {
        OnButtonPressed?.Invoke();
    }
}
