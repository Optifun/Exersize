using UnityEngine;

namespace Player
{
    public class MoveComponent:MonoBehaviour
    {
        [SerializeField] private CharacterController _controller;
        private IInputControls _input;
        [SerializeField] private float _velocity;
       
        private void Awake()
        {
            _controller = GetComponent<CharacterController>();
            _input = GetComponent<IInputControls>();
        }
        
        void Update()
        {
            _controller.Move( _input.Direction * _velocity * Time.deltaTime);
        }
    }
}