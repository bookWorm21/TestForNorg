using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraForCharacterView : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _currentPoint;
    private Vector3 _currentVelocity;

    private void Start()
    {
        _currentPoint = transform.position;
    }

    private void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, _currentPoint, ref _currentVelocity, Time.deltaTime * 2, _speed);
    }

    public void SetPoint(Vector3 point)
    {
        _currentPoint = point;
    }
}
