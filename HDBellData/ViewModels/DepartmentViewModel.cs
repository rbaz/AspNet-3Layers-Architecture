using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HDBellData.ViewModels
{
    public class DepartmentViewModel
    {
        public int DepartmentId { get; set; }
        public string DName { get; set; }

        public virtual ICollection<SelectListItem> Employees { get; set; }
    }
}