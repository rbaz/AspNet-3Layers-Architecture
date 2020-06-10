using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HDBellData.ViewModels
{
    public class TicketViewModel
    {
        public int TicketId { get; set; }

        public DateTime TDateCreation { get; set; }

        [DataType(DataType.MultilineText)]

        public string TDescription { get; set; }

        public string ProjectName { get; set; }

               
        [Required]
        [Display(Name = "Department")]
        public int SelectedDepartmentCode { get; set; }
        public IEnumerable<SelectListItem> Departments { get; set; }

        [Required]
        [Display(Name = "Department / Employee")]
        public int SelectedEmployeeCode { get; set; }
        public IEnumerable<SelectListItem> Employees { get; set; }
    }
}