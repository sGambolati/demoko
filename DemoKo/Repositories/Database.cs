using DemoKo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Concurrent;

namespace DemoKo.Repositories
{
    public static class Database
    {
        private static ConcurrentDictionary<Type, object> Tables;

        static Database()
        {
            Tables = new ConcurrentDictionary<Type, object>();

            Tables.TryAdd(typeof(Pokemon), new ConcurrentDictionary<int, Pokemon>());
        }

        public static IDictionary<int, T> GetTableOf<T>()
        {
            return Tables[typeof(T)] as IDictionary<int, T>;
        }
    }
}