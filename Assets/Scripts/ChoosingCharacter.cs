using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosingCharacter : MonoBehaviour
{
    [SerializeField] private PlayerBodiesActivator _bodiesActivator;
    [SerializeField] private CharacterView[] _views;
    [SerializeField] private CameraForCharacterView _camera;
    [SerializeField] private GameObject _selectingPanel;

    private CharacterView _currentCharacterView;
    private int _currentIndex = 0;
    private int _viewsCount;

    private void Start()
    {
        _currentCharacterView = _views[_currentIndex];
        _viewsCount = _views.Length;
    }

    public void OnClickLeftButton()
    {
        _currentIndex--;
        if(_currentIndex < 0)
        {
            _currentIndex = _viewsCount - 1;
        }

        _camera.SetPoint(_views[_currentIndex].GetCameraPosition());
    }

    public void OnClickRightButton()
    {
        _currentIndex++;
        if (_currentIndex >= _viewsCount)
        {
            _currentIndex = 0;
        }

        _camera.SetPoint(_views[_currentIndex].GetCameraPosition());
    }

    public void OnClickStartButton()
    {
        _selectingPanel.SetActive(false);
        _views[_currentIndex].Select();

        _bodiesActivator.StartGame();
    }
}
