using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDBellData.Models
{
    public partial class Department
    {

        [Key]
        [Column(Order = 1)]
        public int DepartmentId { get; set; }

        public string DName { get; set; }

        public virtual IEnumerable<Employee> Employees { get; set; }
    }
}
