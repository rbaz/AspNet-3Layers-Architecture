using HDBellData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HDBellData.IRepositories
{
    public interface IDepartementRepository : IGenericRepository<Department>
    {
        IEnumerable<SelectListItem> GetDepatments();
    }
}
