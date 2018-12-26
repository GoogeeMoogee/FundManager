using System;
using System.Runtime.Caching;

namespace FundManager.Core.Component
{
    public class CacheHelper
    {
        private const int DefaultExpiration = 5;
        private readonly int _expirationTime = ConfigurationManager.Vault.ContainsKey("SessionExpiration") ? (int)ConfigurationManager.Vault["SessionExpiration"] : DefaultExpiration;
        private static readonly Lazy<CacheHelper> _instance = new Lazy<CacheHelper>(() => new CacheHelper());


        private CacheHelper()
        {}

        public static CacheHelper Instance => _instance.Value;

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
            MemoryCache.Default.Set(key, value, DateTimeOffset.Now.AddMinutes(_expirationTime));
        }

        /// <summary>
        /// Adds if not present or replace the object in the cache by the given key, without expiration time
        /// </summary>
        public void AddWithoutExpiration(string key, object value)
        {
            MemoryCache.Default.Set(key, value, DateTimeOffset.MaxValue);
        }

        /// <summary>
        /// Removes object from the cache by the given key, returns deleted object or null if key is not found
        /// </summary>
        public object Delete(string key)
        {
            return MemoryCache.Default.Remove(key);
        }

        /// <summary>
        /// Check whether cache contains given key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Contains(string key)
        {
            return MemoryCache.Default.Contains(key);
        }
    }
}
