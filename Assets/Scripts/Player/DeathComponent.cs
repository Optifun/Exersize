using System;
using UnityEngine;

namespace Player
{
    public class DeathComponent : MonoBehaviour
    {
        [SerializeField] private HealthComponent _healthComponent;

        private void Awake()
        {
            _healthComponent.HpUpdated += OnHealthUpdated;
        }

        private void OnHealthUpdated(float hp)
        {
            if (hp == 0)
                Destroy(gameObject);
        }

        private void OnDestroy()
        {
            _healthComponent.HpUpdated -= OnHealthUpdated;
        }
    }
}