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
        private IDictionary<int, T> EntitySet;

        public Repository() {
            this.EntitySet = Database.GetTableOf<T>();
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
            this.EntitySet.Add(anEntity.Id, anEntity);

            return anEntity;
        }

        public T Update(T anEntity)
        {
            if (anEntity.Id == 0)
                throw new Exception("El Id de la entidad no puede ser 0");

            this.EntitySet[anEntity.Id] = anEntity;

            return anEntity;
        }

        public void Remove(T anEntity)
        {
            this.Remove(anEntity.Id);
        }

        public void Remove(int Id)
        {
            this.EntitySet.Remove(Id);
        }

        private int GetNextIdentity()
        {
            if(!this.EntitySet.Keys.Any())
                return 0;

            return this.EntitySet.Keys.Max() + 1;
        }
    }
}