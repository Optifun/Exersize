using UnityEngine;

namespace Infrastructure
{
    public abstract class Singleton<T> where T : new()
    {
        private static T _instance;

        public static T Instance => _instance ??= new T();
    }

    public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T _instance;

        public static T Instance => _instance ??= Object.FindObjectOfType<T>() ?? CreateEmpty();

        private static T CreateEmpty()
        {
            var gameObject = new GameObject(nameof(T));
            var behaviour = gameObject.AddComponent<T>();
            return behaviour;
        }
    }
}