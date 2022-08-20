using UnityEngine;

class KeyboardInput : MonoBehaviour, IInputControls
{
    private Vector3 _direction;

    public Vector3 Direction => _direction;

    void Update()
    {
        _direction = Vector3.zero;
        if (Input.GetKey(KeyCode.A))
            _direction += Vector3.left;
        if (Input.GetKey(KeyCode.W))
            _direction += Vector3.forward;
        if (Input.GetKey(KeyCode.D))
            _direction += Vector3.right;
        if (Input.GetKey(KeyCode.S))
            _direction += Vector3.back;

        _direction.Normalize();
    }
}