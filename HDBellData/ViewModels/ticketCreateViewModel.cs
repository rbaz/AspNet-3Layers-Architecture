using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDBellData.ViewModels
{
    public class TicketCreateViewModel
    {
        public int TicketId { get; set; }

        public DateTime TDateCreation { get; set; }

        [DataType(DataType.MultilineText)]
        public string TDescription { get; set; }

        public string ProjectName { get; set; }

        [Display(Name = "Department")]
        public string DName { get; set; }

        [Display(Name = "Employee")]
        public string Name { get; set; }
    }
}