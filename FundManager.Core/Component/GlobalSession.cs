using System;
using System.Runtime.Caching;

namespace FundManager.Core.Component
{
    public class GlobalSession
    {
        private const int DefaultExpiration = 5;
        private static readonly Lazy<GlobalSession> _instance = new Lazy<GlobalSession>(() => new GlobalSession());

        private GlobalSession()
        {}

        public static GlobalSession Instance => _instance.Value;

        /// <summary>
        /// Gets object from the cache by the given key
        /// </summary>
        public object Get(string key)
        {
            return MemoryCache.Default.Get(key);
        }

        /// <summary>
        /// Adds if not present or replace the object in the cache by the given key, default expiration time is used
        /// </summary>
        public void Add(string key, object value)
        {
            var expirationInMinutes = ConfigurationManager.Vault.ContainsKey("SessionExpiration") ? (int)ConfigurationManager.Vault["SessionExpiration"] : DefaultExpiration;

            MemoryCache.Default.Set(key, value, DateTimeOffset.Now.AddMinutes(expirationInMinutes));
        }

        /// <summary>
        /// Removes object from the cache by the given key, returns deleted object or null if key is not found
        /// </summary>
        public object Delete(string key)
        {
            return MemoryCache.Default.Remove(key);
        }
    }
}
