using DemoKo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Concurrent;

namespace DemoKo.Repositories
{
    public class Repository<T> where T : Entity
    {
        private ConcurrentDictionary<int, T> EntitySet;

        public Repository() {
            this.EntitySet = new ConcurrentDictionary<int, T>();
        }

        public T Get(int Id)
        {
            if (!this.EntitySet.ContainsKey(Id))
                return null;

            return this.EntitySet[Id];
        }

        public IEnumerable<T> List()
        {
            return this.EntitySet.Values;
        }

        public T Add(T anEntity)
        { 
            if(anEntity.Id != 0)
                throw new Exception("El Id de la entidad no es 0");

            anEntity.Id = this.GetNextIdentity();
            this.EntitySet.TryAdd(anEntity.Id, anEntity);

            return anEntity;
        }

        public T Update(T anEntity)
        {
            if (anEntity.Id == 0)
                throw new Exception("El Id de la entidad no puede ser 0");

            this.EntitySet[anEntity.Id] = anEntity;

            return anEntity;
        }

        public T Remove(T anEntity)
        {
            return this.Remove(anEntity.Id);
        }

        public T Remove(int Id)
        {
            T deleted;
            this.EntitySet.TryRemove(Id, out deleted);

            return deleted;
        }

        private int GetNextIdentity()
        {
            if(!this.EntitySet.Keys.Any())
                return 0;

            return this.EntitySet.Keys.Max();
        }
    }
}