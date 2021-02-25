using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterView : MonoBehaviour
{
    [SerializeField] private Transform _neededCameraPosition;
    [SerializeField] private PlayerBody _body;

    public Vector3 GetCameraPosition()
    {
        return _neededCameraPosition.position;
    }

    public void Select()
    {
        _body.Select();
    }
}
