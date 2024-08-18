using Prism.Mvvm;
using Prism.Navigation;
using Prism.Regions;
using System.Collections.Generic;
using System;

namespace CpiDataClient.Core.Mvvm
{
    public abstract class ViewModelBase : BindableBase, IDestructible
    {
        private readonly Dictionary<string, object> services = new();

        public void RegisterService<T>(string key, T service)
        {
            var serviceKey = GetServiceKey<T>(key);
            if (!services.ContainsKey(serviceKey))
            {
                services[serviceKey] = service;
            }
        }

        protected T GetService<T>(string key = null)
        {
            var serviceKey = GetServiceKey<T>(key);
            services.TryGetValue(serviceKey, out var service);
            
            return (T)service;
        }

        private string GetServiceKey<T>(string key)
        {
            return $"{typeof(T).FullName}:{key}";
            
        }

        protected ViewModelBase()
        {

        }

        public virtual void Destroy()
        {

        }
    }
}
