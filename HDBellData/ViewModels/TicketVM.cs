using HDBellData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDBellData.ViewModels
{
    public class TicketVM
    {
        public int TicketId { get; set; }
        public DateTime TDateCreation { get; set; }
        [DataType(DataType.MultilineText)]
        public string TDescription { get; set; }
        public string ProjectName { get; set; }

        public virtual int DepartmentId { get; set; }
        public virtual DepartmentVM Department { get; set; }

        public virtual int EmployeeId { get; set; }
        public virtual EmployeeVM Employee { get; set; }
    }
}
