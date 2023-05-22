using UnityEngine;
using Zenject;

public class PlayerMovePresenter : MonoBehaviour
{
    [SerializeField] private JoystickView _joystickView;

    private Mover _mover;

    [Inject]
    public void Construct(Mover mover)
    {
        _mover = mover;
    }

    private void OnEnable()
    {
        _joystickView.Moved += OnMoved;
    }

    private void OnDisable()
    {
        _joystickView.Moved -= OnMoved;
    }

    private void OnMoved(float horizontal, float vertical)
    {
        transform.position = new Vector2(transform.position.x + horizontal * _mover.Speed * Time.deltaTime, transform.position.y + vertical * _mover.Speed * Time.deltaTime);
    }
}
