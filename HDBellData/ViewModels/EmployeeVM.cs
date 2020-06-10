using HDBellData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDBellData.ViewModels
{
    public class EmployeeVM
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public virtual int DepartementId { get; set; }
        public virtual DepartmentVM Department { get; set; }
    }
}
