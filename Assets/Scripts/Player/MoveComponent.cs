using UnityEngine;

namespace Player
{
    public class MoveComponent:MonoBehaviour
    {
        [SerializeField] private CharacterController _controller;
        private InputControls _input;
        [SerializeField] private float _velocity;
        private float destinationDistance;

        private void Awake()
        {
            _controller = GetComponent<CharacterController>();
            _input = GetComponent<InputControls>();
        }
        
        void Update()
        {
            Quaternion rawRoation = Quaternion.Slerp(transform.rotation, _input.Rotation, _velocity * Time.deltaTime);
            transform.rotation = new Quaternion(0, rawRoation.y, 0, rawRoation.w);

            _controller.Move(_input.Direction * _velocity * Time.deltaTime);            
        }
    }
}