using HDBellData;
using HDBellData.IRepositories;
using HDBellData.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HDBellService.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public IEnumerable<SelectListItem> GetEmployeeByDepartment()
        {
            List<SelectListItem> employees = new List<SelectListItem>()
            {
                new SelectListItem
                {
                    Value = null,
                    Text = " "
                }
            };
            return employees;
        }

        public IEnumerable<SelectListItem> GetEmployeeByDepartment(int departmentId)
        {            
            
                using (var context = _context)
                {
                IEnumerable<SelectListItem> employees = context.Employees.AsNoTracking()
                    .OrderBy(n => n.Name)
                    .Where(n => n.DepartmentId == departmentId)
                    .Select(n =>
                       new SelectListItem
                       {
                           Value = n.EmployeeId.ToString(),
                           Text = n.Name,
                           Selected = n.EmployeeId.ToString() == "SelectedEmployeeCode" ? true : false                           
                           }).ToList();
                
                    return new SelectList(employees, "Value", "Text", "SelectedEmployeeCode");
                }            
        }        
    }
}
