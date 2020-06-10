using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HDBellData.ViewModels
{
    public class EmployeeViewModel
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public virtual int DepartmentId { get; set; }
    }
}