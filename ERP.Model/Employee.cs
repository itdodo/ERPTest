using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Model
{
    public class Employee
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string EmpName { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNum { get; set; }
        public string Emali { get; set; }
        public string QQ { get; set; }
    }
}
