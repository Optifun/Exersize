using Player;
using UnityEngine;

namespace Enemy
{
    public class DeadZone : MonoBehaviour
    {
        [SerializeField] private float _damageValue = 1;

        private void OnTriggerStay(Collider other)
        {
            var component = other.GetComponent<HealthComponent>();
            component.ModifyHp(-_damageValue * Time.fixedDeltaTime);
        }
    }
}