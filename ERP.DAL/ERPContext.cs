using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ERP.Model;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ERP.DAL
{
    public class ERPContext :DbContext
    {
        public ERPContext() :base("ERPContext") { }
        public DbSet<Employee> employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
