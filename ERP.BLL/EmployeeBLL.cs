using ERP.DAL;
using ERP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ERP.BLL
{
    public class EmployeeBLL
    {
        public bool CreateEmployee(Employee model)
        {
            ERPContext db = new ERPContext();
            db.employees.Add(model);
            db.SaveChanges();
            return true;
;        }
    }
}
