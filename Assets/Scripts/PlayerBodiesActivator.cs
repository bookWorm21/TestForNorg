using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBodiesActivator : MonoBehaviour
{
    [SerializeField] private PlayerBody[] _bodies;

    public void StartGame()
    {
        for(int i = 0; i < _bodies.Length; i++)
        {
            _bodies[i].StartGame();
        }
    }
}
