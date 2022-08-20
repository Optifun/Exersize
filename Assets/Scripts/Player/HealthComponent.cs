using System;
using UnityEngine;

namespace Player
{
    public class HealthComponent : MonoBehaviour
    {
        public event Action<float> HpUpdated;
        [field: SerializeField] public float Health { get; protected set; }

        public void Initialize(float initialValue)
        {
            Health = initialValue;
        }

        public void ModifyHp(float value)
        {
            float newHp = Health + value;
            if (newHp < 0)
                SetHp(0);
            else
                SetHp(newHp);
        }

        private void SetHp(float value)
        {
            if (Health == value)
                return;

            Health = value;
            HpUpdated?.Invoke(Health);
        }
    }
}