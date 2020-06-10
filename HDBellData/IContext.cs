using HDBellData.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDBellData
{
    public interface IContext
    {
        IDbSet<Employee> Employees { get; set; }
        IDbSet<Department> Departments { get; set; }
        IDbSet<Ticket> Tickets { get; set; }
        IDbSet<Project> Projects { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        int SaveChanges();
    }

}
