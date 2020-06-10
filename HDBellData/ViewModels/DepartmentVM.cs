using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDBellData.ViewModels
{
    public class DepartmentVM
    {
        public int DepartmentId { get; set; }
        public string DName { get; set; }

        public virtual ICollection<EmployeeVM> Employees { get; set; }
    }
}
