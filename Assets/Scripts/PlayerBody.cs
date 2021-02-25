using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBody : MonoBehaviour
{
    [SerializeField] private GameObject _mesh;

    public bool Selected { get; private set; }

    public void StartGame()
    {
        _mesh.SetActive(Selected);
    }

    public void Select()
    {
        Selected = true;
    }

    public void UnSelect()
    {
        Selected = false;
    }
}
