using Unity.VisualScripting;
using UnityEngine;

namespace Infrastructure
{
    public class A1 : Singleton<A1>
    {
        public void Act()
        {
            Debug.Log($"A1 Act");
        }
    }
}