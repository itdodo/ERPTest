using ERP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure;

namespace ERP.DAL
{
    public class ERPContext :DbContext
    {
        public ERPContext() :base("name=ERPContext") 
        { 
        }
        public DbSet<Employee> employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
