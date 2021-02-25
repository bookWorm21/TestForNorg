using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGameButton : MonoBehaviour
{
    [SerializeField] private GameObject _chooseCharacterCamera;
    [SerializeField] private GameObject _mainGameCamera;
    [SerializeField] private PlayerMoving _playerMoving;
    [SerializeField] private ChoosingCharacter _choosing;

    private Button _button;

    private void Start()
    {
        _button = GetComponent<Button>();
        _playerMoving.enabled = false;
        _button.onClick.AddListener(OnClickStartButton);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(OnClickStartButton);
    }

    private void OnClickStartButton()
    {
        _choosing.OnClickStartButton();
        _chooseCharacterCamera.SetActive(false);
        _mainGameCamera.SetActive(true);
        _playerMoving.enabled = true;
    }
}

