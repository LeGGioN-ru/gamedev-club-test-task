using System;
using UnityEngine;

public class JoystickView : MonoBehaviour
{
    [SerializeField] private PlayerMovePresenter _playerMover;
    [SerializeField] private FixedJoystick _joystick;

    public Action<float, float> Moved;

    private void Update()
    {
        if (_joystick.Vertical != 0 || _joystick.Horizontal != 0)
            Moved?.Invoke(_joystick.Horizontal, _joystick.Vertical);
    }
}
