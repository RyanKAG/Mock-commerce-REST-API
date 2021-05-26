using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Data
{
    public interface IRepo<T> 
    {
        ActionResult<IEnumerable<T>> GetAll();
        ActionResult<T> Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        bool SaveChanges();

    }
}