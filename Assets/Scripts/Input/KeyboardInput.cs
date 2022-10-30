using UnityEngine;

class KeyboardInput : MonoBehaviour, InputControls
{
    private Vector3 _direction;
    private Vector3 _target;
    private Quaternion _rotation;
    private float destinationDistance;

    public Vector3 Direction => _direction;
    public Vector3 Target => _target;
    public Quaternion Rotation => _rotation;

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

        if (Input.GetKey(KeyCode.Mouse1)) {
            _target = Input.mousePosition;
            _rotation = Quaternion.LookRotation(_target - transform.position);

        }

        //двигаться вперёд пока не достигнута целевая точка
        if (_target.magnitude != 0)
        {
            destinationDistance = Vector3.Distance(_target, transform.position);
            if (destinationDistance > .5f)
                _direction += Vector3.forward;
        }
        

        _direction.Normalize();
    }
}