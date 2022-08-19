using System;
using System.Collections.Generic;

namespace Infrastructure
{
    public class AllServices : Singleton<AllServices>
    {
        private readonly Dictionary<Type, object> _objects = new Dictionary<Type, object>();

        public void RegisterSingle<TService>(TService implementation) =>
            _objects.Add(typeof(TService), implementation);

        public TService Single<TService>()
        {
            if (_objects.TryGetValue(typeof(TService), out var obj))
                return (TService) obj;

            throw new ArgumentException($"Specified type is not registered, {nameof(TService)}");
        }

        private static class Implementation<TService>
        {
            public static TService ServiceInstance;
        }
    }
}