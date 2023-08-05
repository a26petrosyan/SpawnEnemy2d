using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMover))]
public class PlayerInput : MonoBehaviour
{
    private PlayerMover _playerMover;

    private void Start()
    {
        _playerMover = GetComponent<PlayerMover>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _playerMover.TryMoveUp();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _playerMover.TryMoveDown();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _playerMover.TryMoveLeft();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _playerMover.TryMoveRight();
        }
    }
}
