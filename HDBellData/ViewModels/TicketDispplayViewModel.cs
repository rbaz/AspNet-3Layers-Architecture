using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDBellData.ViewModels
{
    public class TicketDisplayViewModel
    {
        public int TicketId { get; set; }

        public DateTime TDateCreation { get; set; }

        [DataType(DataType.MultilineText)]
        public string TDescription { get; set; }

        public string ProjectName { get; set; }
        
        public string DName { get; set; }
        
        public string Name { get; set; }

    }
}
