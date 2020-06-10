using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HDBellData.Models;
using HDBellService;
using HDBellData.IRepositories;
using HDBellData.ViewModels;
using HDBellService.Repositories;

namespace HDBellWebUI.Controllers
{
    public class TicketController : Controller
    {

        private IGenericRepository<Ticket> _repository = null;
        private ITicketRepository _ticketRepository = null;


        public TicketController()
        {
            this._repository = new GenericRepository<Ticket>();
            this._ticketRepository = new TicketRepository();
        }

        public TicketController(TicketRepository repository)
        {
            this._ticketRepository = repository;
        }

        public TicketController(IGenericRepository<Ticket> repository)
        {
            this._repository = repository;
        }


        [HttpGet]
        public ActionResult Index(string Sorting_Order, string Search_ProjectName, string Search_EmployeeName, string Search_Description)
        {            

            var tickets = _ticketRepository.GetAll();
            var ticketsDisplayViewModel = new List<TicketDisplayViewModel>();

            ticketsDisplayViewModel = (from ticket in tickets
                                       select new TicketDisplayViewModel
                                       {
                                           TicketId = ticket.TicketId,
                                           ProjectName = ticket.ProjectName,
                                           TDescription = ticket.TDescription,
                                           TDateCreation = ticket.TDateCreation,
                                           Name = ticket.Employee.Name,
                                           DName = ticket.Employee.Department.DName
                                       }).ToList();


            if (!String.IsNullOrEmpty(Search_ProjectName))
            {
                ticketsDisplayViewModel = ticketsDisplayViewModel.Where(t => t.ProjectName.Contains(Search_ProjectName)).ToList();
            }

            if (!String.IsNullOrEmpty(Search_EmployeeName))
            {
                ticketsDisplayViewModel = ticketsDisplayViewModel.Where(t => t.Name.Contains(Search_EmployeeName)).ToList();
            }

            if (!String.IsNullOrEmpty(Search_Description))
            {
                ticketsDisplayViewModel = ticketsDisplayViewModel.Where(t => t.TDescription.Contains(Search_Description)).ToList();
            }

            switch (Sorting_Order)
            {
                case "ProjectName":
                    ticketsDisplayViewModel = ticketsDisplayViewModel.OrderByDescending(tick => tick.ProjectName).ToList();
                    break;
                case "EmployeeName":
                    ticketsDisplayViewModel = ticketsDisplayViewModel.OrderBy(tick => tick.Name).ToList();
                    break;
                case "Description":
                    ticketsDisplayViewModel = ticketsDisplayViewModel.OrderByDescending(tick => tick.TDescription).ToList();
                    break;
                default:
                    ticketsDisplayViewModel = ticketsDisplayViewModel.OrderBy(tick => tick.TDateCreation).ToList();
                    break;
            }

            return View(ticketsDisplayViewModel);

        }


        [HttpGet]
        public ActionResult GetEmployeeByDepartment(int DepartmentId)
        {
            var repo = new EmployeeRepository();

            IEnumerable<SelectListItem> employees = repo.GetEmployeeByDepartment(DepartmentId);
            return Json(employees, JsonRequestBehavior.AllowGet);

        }

        // GET: Tickets/Create
        [HttpGet]
        public ActionResult Create()
        {
            var ticket = _ticketRepository.CreateTicket();
            return View(ticket);
        }

        // GET: Tickets/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "TicketId, TDateCreation, TDescription, ProjectName, SelectedEmployeeCode")] TicketEditViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool saved = _ticketRepository.SaveTicket(model);
                    if (saved)
                    {
                        return RedirectToAction("Index");
                    }
                }
                // Handling model state errors is beyond the scope of the demo, so just throwing an ApplicationException when the ModelState is invalid
                // and rethrowing it in the catch block.
                throw new ApplicationException("Invalid model");
            }
            catch (ApplicationException ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Ticket ticket = _ticketRepository.GetById(id);
            var _employeeRepository = new EmployeeRepository();
            var _departmentRepository = new DepartmentRepository();

            var departments = _departmentRepository.GetDepatments();
            var employees = _employeeRepository.GetEmployeeByDepartment(ticket.Employee.DepartmentId);


            var ticketEditViewModel = new TicketEditViewModel
            {
                TicketId = ticket.TicketId,
                ProjectName = ticket.ProjectName,
                TDescription = ticket.TDescription,
                TDateCreation = ticket.TDateCreation,
                SelectedEmployeeCode = ticket.EmployeeId,
                SelectedDepartmentCode = ticket.Employee.DepartmentId,
                Departments = departments,
                Employees = employees                
            };

            return View(ticketEditViewModel);
            
        }



    [HttpGet]
    public ActionResult EditTicket(int id)
        {
            Ticket ticket = _ticketRepository.GetById(id);
            var _employeeRepository = new EmployeeRepository();
            var _departmentRepository = new DepartmentRepository();

            var departments = _departmentRepository.GetDepatments();
            var employees = _employeeRepository.GetEmployeeByDepartment(ticket.Employee.DepartmentId);


            var ticketEditViewModel = new TicketEditViewModel
            {
                TicketId = ticket.TicketId,
                ProjectName = ticket.ProjectName,
                TDescription = ticket.TDescription,
                TDateCreation = ticket.TDateCreation,
                SelectedEmployeeCode = ticket.EmployeeId,
                SelectedDepartmentCode = ticket.Employee.DepartmentId,
                Departments = departments,
                Employees = employees                
            };

            var selected = employees.FirstOrDefault(x => x.Value == ticketEditViewModel.SelectedEmployeeCode.ToString());
            selected.Selected = true;

            ViewBag.employeeName = employees.Where(e => e.Value == ticketEditViewModel.SelectedEmployeeCode.ToString()).First();
            return View(ticketEditViewModel);
        }

        [HttpPost]
        public ActionResult Save(Ticket model)
        {
            if (ModelState.IsValid)
            {
                _ticketRepository.Update(model);
                _ticketRepository.Save();
                return RedirectToAction("Index", "Ticket");
            }
            else
            {
                return View(model);
            }
        }

        //[HttpGet]
        //public ActionResult Delete(int TicketId)
        //{
        //    Ticket model = _ticketRepository.GetById(TicketId);
        //    return View(model);
        //}

        [HttpPost]
        public ActionResult Delete(int TicketId)
        {
            _ticketRepository.Delete(TicketId);
            _ticketRepository.Save();
            return RedirectToAction("Index", "Ticket");
        }
    }
}
