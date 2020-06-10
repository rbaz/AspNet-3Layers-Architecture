using HDBellData.IRepositories;
using HDBellData.Models;
using HDBellData.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace HDBellService.Repositories
{
    public class TicketRepository : GenericRepository<Ticket>, ITicketRepository
    {
        public TicketEditViewModel CreateTicket()
        {
            var departmentRepository = new DepartmentRepository();
            var employeeRepository = new EmployeeRepository();
            var ticket = new TicketEditViewModel()
            {
                //TicketId = Guid.NewGuid().ToString(), 
                
                Departments = departmentRepository.GetDepatments(),
                Employees = employeeRepository.GetEmployeeByDepartment()
            };
            return ticket;
        }

        public IEnumerable<TicketDisplayViewModel> GetTickets()
        {
            using (var context = _context)
            {
                List<Ticket> tickets = new List<Ticket>();
                tickets = context.Tickets.AsNoTracking()
                    .Include(x => x.Employee)
                    .Include(x => x.Employee.Department)
                    .ToList();

                if (tickets != null)
                {
                    List<TicketDisplayViewModel> ticketsDisplay = new List<TicketDisplayViewModel>();
                    foreach (var x in tickets)
                    {
                        var ticketDisplay = new TicketDisplayViewModel()
                        {
                            TicketId = x.TicketId,
                            TDescription = x.TDescription,
                            ProjectName = x.ProjectName,
                            TDateCreation = x.TDateCreation,
                            Name = x.Employee.Name,
                            DName = x.Employee.Department.DName
                        };
                        ticketsDisplay.Add(ticketDisplay);
                    }
                    return ticketsDisplay;
                }
                return null;
            }
        }

        public bool SaveTicket(TicketEditViewModel ticketEdit)
        {
            if (ticketEdit != null)
            {
                using (var context = _context)
                {
                    var ticket = new Ticket()
                    {
                        TicketId = ticketEdit.TicketId,
                        TDateCreation = DateTime.Now, /*ticketEdit.TDateCreation,*/
                        TDescription = ticketEdit.TDescription, // SelectedCountryIso3,
                        ProjectName = ticketEdit.ProjectName,
                        EmployeeId = ticketEdit.SelectedEmployeeCode
                    };
                    //ticket.Employee = context.Employees.Find(ticketEdit.SelectedEmployeeCode);
                    //ticket.Employee.Department = context.Departments.Find(ticketEdit.SelectedDepartmentCode);

                    context.Tickets.Add(ticket);
                    context.SaveChanges();
                    return true;
                }
            }
            // Return false if customeredit == null or CustomerID is not a guid
            return false;
        }
    }
}