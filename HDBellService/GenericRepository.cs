using HDBellData;
using HDBellData.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDBellService
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public HDBellContext _context = null;
        public DbSet<T> table = null;

        public GenericRepository()
        {
            this._context = new HDBellContext();
            table = _context.Set<T>();
        }

        public GenericRepository(HDBellContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(int id)
        {
            return table.Find(id);
        }

        public T Insert(T entity)
        {
            table.Add(entity);
            return entity;
        }

        public T Update(T entity)
        {
            table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public bool Delete(int id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
            if (table.Find(id) == null)
            {
                return true;
            }
            return false;
            
        }

        public bool Save()
        {
            _context.SaveChanges();
            if (_context.SaveChanges() > 0)
            {
                return true;
            }
            return false;
        }        
    }
}
