using System;
using UnityEngine;

namespace Infrastructure
{
    public class A2 : MonoSingleton<A2>
    {
        private void Start()
        {
            Debug.Log("A2 spawned");
        }
        
        public void Act() => 
            Debug.Log($"A2 Act");
    }
}