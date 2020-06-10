using HDBellData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HDBellData.IRepositories
{
    public interface IEmployeeRepository: IGenericRepository<Employee>
    {
        IEnumerable<SelectListItem> GetEmployeeByDepartment();
        IEnumerable<SelectListItem> GetEmployeeByDepartment(int departmentId);
    }
}
