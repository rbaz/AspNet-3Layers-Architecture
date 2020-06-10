using HDBellData.Models;
using HDBellData.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace HDBellData.IRepositories
{
    public interface ITicketRepository : IGenericRepository<Ticket>
    {
        IEnumerable<TicketDisplayViewModel> GetTickets();
        TicketEditViewModel CreateTicket();
        bool SaveTicket(TicketEditViewModel ticketEdit);
    }
}
