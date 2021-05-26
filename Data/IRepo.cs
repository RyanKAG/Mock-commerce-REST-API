using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace personalAPI.Data
{
    public interface IRepo<T> 
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        bool SaveChanges();

    }
}