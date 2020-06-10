
using HDBellData.IRepositories;
using HDBellData.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;


namespace HDBellService.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartementRepository
    {       

        public IEnumerable<SelectListItem> GetDepatments()
        {
            using (var context = _context)
            {
                List<SelectListItem> departments = context.Departments.AsNoTracking()
                                                   .OrderBy(n => n.DName)
                                                   .Select(n =>   new SelectListItem
                                                   {
                                                       Value = n.DepartmentId.ToString(),
                                                       Text = n.DName
                                                   }).ToList();

                var departmenttip = new SelectListItem()
                {
                    Value = null,
                    Text = "--- select department ---"
                };

                departments.Insert(0, departmenttip);
                return new SelectList(departments, "Value", "Text", "SelectedDepartmentCode");                
            }
        }
    }
}
