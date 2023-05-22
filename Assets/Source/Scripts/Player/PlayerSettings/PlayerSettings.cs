using UnityEngine;

[CreateAssetMenu(fileName = "Player Settings", menuName = "Player", order = 51)]
public class PlayerSettings : ScriptableObject
{
    [SerializeField] private float _speed;

    public float Speed => _speed;
}
