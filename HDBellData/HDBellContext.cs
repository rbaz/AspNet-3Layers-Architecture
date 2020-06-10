using HDBellData.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace HDBellData
{
    public class HDBellContext : DbContext, IContext
    {

        public HDBellContext() : base("name=HDeskBellDB")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<HDBellContext, Migrations.Configuration>());
        }

        public IDbSet<Department> Departments { get; set; }
        public IDbSet<Employee> Employees { get; set; }
        public IDbSet<Ticket> Tickets { get; set; }
        public IDbSet<Project> Projects { get; set; }        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new Migrations.Configuration());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => x.State == System.Data.Entity.EntityState.Added || x.State == System.Data.Entity.EntityState.Modified);

            foreach (var entry in modifiedEntries)
            {
                if (entry.Entity != null)
                {
                    string identityName = Thread.CurrentPrincipal.Identity.Name;
                    DateTime now = DateTime.UtcNow;
                }             
            }

            return base.SaveChanges();
        }
    }
}
