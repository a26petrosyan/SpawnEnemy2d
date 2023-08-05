using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _moveSizeHeight;
    [SerializeField] private float _moveSizeWidth;
    [SerializeField] private float _maxHeight;
    [SerializeField] private float _minHeight;
    [SerializeField] private float _maxWidth;
    [SerializeField] private float _minWidth;
    private Vector3 _target;

    private void Start()
    {
        _target = transform.position;
    }

    private void Update()
    {
        if(transform.position != _target)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
        }
    }

    public void TryMoveLeft()
    {
        if (_target.x > _minWidth)
            SetNextPosition(-_moveSizeWidth, 0);
    }

    public void TryMoveRight()
    {
        if (_target.x < _maxWidth)
            SetNextPosition(_moveSizeWidth, 0);
    }

    public void TryMoveDown()
    {
        if (_target.y > _minHeight)
            SetNextPosition(0, -_moveSizeHeight);
    }

    public void TryMoveUp()
    {
        if (_target.y < _maxHeight)
            SetNextPosition(0, _moveSizeHeight);
    }

    public void SetNextPosition(float moveSizeWidth, float moveSizeHeight)
    {
        _target = new Vector2(_target.x + moveSizeWidth, _target.y + moveSizeHeight);
    }
}
