using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    [SerializeField] private Joystick _joystick;
    [SerializeField] private float _speed;
    [SerializeField] private Animator _animator;
    [SerializeField] private Transform _bodyRoot;
    [SerializeField] private Transform _targetForRotation;

    private int _animatorMoving = Animator.StringToHash("isMove");

    private Vector3 _moving;

    private void Update()
    {
        if(_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            _animator.SetBool(_animatorMoving, true);
            _moving = new Vector3(_joystick.Horizontal, 0, _joystick.Vertical);
            transform.Translate(_moving * _speed * Time.deltaTime);
            _targetForRotation.position = _bodyRoot.position + _moving;
            _bodyRoot.LookAt(_targetForRotation);
        }
        else
        {
            _animator.SetBool(_animatorMoving, false);
        }
    }
}
