//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Linq;
//using System.Threading.Tasks;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;
//using HDBellData;

//namespace HDBellWebUI.Controllers
//{
//    public class TicketController : Controller
//    {
//        private HDBellData.HDBellContext db = new HDBellData.HDBellContext();

//        // GET: Tickets
//        [HttpGet]
//        public async Task<ActionResult> Index()
//        {
//            var tickets = db.Tickets.Include(t => t.Department).Include(e => e.Employee);            

//            return View(await tickets.ToListAsync());
//        }

//        //// GET: Tickets/Details/5
//        //[HttpGet]
//        //public async Task<ActionResult> Details(int? id)
//        //{
//        //    if (id == null)
//        //    {
//        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//        //    }
//        //    HDBellData.Ticket ticket = await db.Tickets.FindAsync(id);
//        //    if (ticket == null)
//        //    {
//        //        return HttpNotFound();
//        //    }
//        //    return View(ticket);
//        //}

//        //// GET: Tickets/Create
//        //[HttpGet]
//        //public ActionResult Create()
//        //{
//        //    ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "DName");
//        //    ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "Name");
//        //    return View();
//        //}

//        //// POST: Tickets/Create
//        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        //[HttpPost]
//        //[ValidateAntiForgeryToken]
//        //public async Task<ActionResult> Create([Bind(Include = "TicketId,TDateCreation,TDescription,ProjectName,DepartmentId,EmployeeId")] HDBellData.Ticket ticket)
//        //{
//        //    if (ModelState.IsValid)
//        //    {
//        //        //set datetime to now
//        //        db.Entry(ticket).Entity.TDateCreation = DateTime.Now;

//        //        db.Tickets.Add(ticket);
//        //        await db.SaveChangesAsync();
//        //        return RedirectToAction("Index");
//        //    }

//        //    ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "DName", ticket.DepartmentId);
//        //    ViewBag.EmployeeId = new SelectList(db.Employees, "EmployeeId", "Name", ticket.EmployeeId);
//        //    return View(ticket);
//        //}

//        //// GET: Tickets/Edit/5
//        //public async Task<ActionResult> Edit(int? id)
//        //{
//        //    if (id == null)
//        //    {
//        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//        //    }
//        //    HDBellData.Ticket ticket = await db.Tickets.FindAsync(id);
//        //    if (ticket == null)
//        //    {
//        //        return HttpNotFound();
//        //    }
//        //    ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "DName", ticket.DepartmentId);
//        //    ViewBag.EmployeeId = new SelectList(db.Employees, "DepartmentId", "Name", ticket.EmployeeId);

//        //    return View(ticket);
//        //}

//        //// POST: Tickets/Edit/5
//        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
//        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
//        //[HttpPost]
//        //[ValidateAntiForgeryToken]
//        //public async Task<ActionResult> Edit([Bind(Include = "TicketId,TDateCreation,TDescription,ProjectName,DepartmentId,EmployeeId")] HDBellData.Ticket ticket)
//        //{
//        //    if (ModelState.IsValid)
//        //    {
//        //        db.Entry(ticket).State = EntityState.Modified;
//        //        await db.SaveChangesAsync();
//        //        return RedirectToAction("Index");
//        //    }

//        //    ViewBag.DepartmentId = new SelectList(db.Departments, "DepartmentId", "DName", ticket.DepartmentId);
//        //    ViewBag.EmplouyeeId = new SelectList(db.Employees, "EmployeeId", "Name", ticket.EmployeeId);
//        //    return View(ticket);
//        //}

//        //// GET: Tickets/Delete/5
//        //public async Task<ActionResult> Delete(int? id)
//        //{
//        //    if (id == null)
//        //    {
//        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
//        //    }
//        //    HDBellData.Ticket ticket = await db.Tickets.FindAsync(id);
//        //    if (ticket == null)
//        //    {
//        //        return HttpNotFound();
//        //    }
//        //    return View(ticket);
//        //}

//        //// POST: Tickets/Delete/5
//        //[HttpPost, ActionName("Delete")]
//        //[ValidateAntiForgeryToken]
//        //public async Task<ActionResult> DeleteConfirmed(int id)
//        //{
//        //    HDBellData.Ticket ticket = await db.Tickets.FindAsync(id);
//        //    db.Tickets.Remove(ticket);
//        //    await db.SaveChangesAsync();
//        //    return RedirectToAction("Index");
//        //}

//        //protected override void Dispose(bool disposing)
//        //{
//        //    if (disposing)
//        //    {
//        //        db.Dispose();
//        //    }
//        //    base.Dispose(disposing);
//        //}
        
//    }
//}
