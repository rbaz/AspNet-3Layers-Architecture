//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Data.Entity.Migrations;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HDBellData
//{
//    public class HDBContext : DbContext
//    {
//        public HDBContext() : base("HDeskDBellDB")
//        {
//            Database.SetInitializer(new HDeskDBellDBInitializer());
//        }

//        public DbSet<Department> Deprtments { get; set; }
//        public DbSet<Employee> Employees { get; set; }
//        public DbSet<Ticket> Tickets { get; set; }

//        protected override void OnModelCreating(DbModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);
//        }
//    }


//    public class HDeskDBellDBInitializer : DropCreateDatabaseAlways<HDBContext>
//    {
//        protected override void Seed(HDBContext context)
//        {
//            context.Deprtments.AddOrUpdate(x => x.DepartmentId,
//                new Department() { DepartmentId = 1, DName = "Division of Telecommunications Extranet Development" },
//                 new Department() { DepartmentId = 2, DName = "Extranet Multimedia Connectivity and Security Division" },
//                 new Department() { DepartmentId = 3, DName = "Branch of Extranet Implementation" },
//                 new Department() { DepartmentId = 4, DName = "Branch of Intranet Computer Maintenance and E-Commerce PC Programming" },
//                 new Department() { DepartmentId = 5, DName = "Wireless Extranet Backup Team" },
//                 new Department() { DepartmentId = 6, DName = "Database Programming Branch" },
//                 new Department() { DepartmentId = 7, DName = "Hardware Backup Department" },
//                 new Department() { DepartmentId = 8, DName = "Multimedia Troubleshooting and Maintenance Team" },
//                 new Department() { DepartmentId = 9, DName = "Office of Statistical Data Connectivity" },
//                 new Department() { DepartmentId = 10, DName = "Division of Application Security" },
//                 new Department() { DepartmentId = 11, DName = "Network Maintenance and Multimedia Implementation Committee" },
//                 new Department() { DepartmentId = 12, DName = "PC Maintenance Department" },
//                 new Department() { DepartmentId = 13, DName = "Bureau of Business-Oriented PC Backup and Wireless Telecommunications Control" },
//                 new Department() { DepartmentId = 14, DName = "Software Technology and Networking Department" }
//                );

//            context.Employees.AddOrUpdate(x => x.EmployeeId,
//                new Employee() { EmployeeId = 1, Name = "Roma Marcell", DepartementId = 1 },
//                new Employee() { EmployeeId = 2, Name = "Hugo Wess", DepartementId = 2 },
//                new Employee() { EmployeeId = 3, Name = "Kelvin Lahr", DepartementId = 3 },
//                new Employee() { EmployeeId = 4, Name = "Janelle Newberg", DepartementId = 1 },
//                new Employee() { EmployeeId = 5, Name = "Mellie Lombard", DepartementId = 4 },
//                new Employee() { EmployeeId = 6, Name = "Reita Abshire", DepartementId = 5 },
//                new Employee() { EmployeeId = 7, Name = "Dalila Vickrey", DepartementId = 6 },
//                new Employee() { EmployeeId = 8, Name = "Idella Dallman", DepartementId = 3 },
//                new Employee() { EmployeeId = 9, Name = "Farah Eldridge", DepartementId = 7 },
//                new Employee() { EmployeeId = 10, Name = "Lana Montes", DepartementId = 7 },

//                new Employee() { EmployeeId = 11, Name = "Leola Thornburg", DepartementId = 2 },
//                new Employee() { EmployeeId = 12, Name = "Marcelo Paris", DepartementId = 6 },
//                new Employee() { EmployeeId = 13, Name = "Ione Tomlin", DepartementId = 8 },
//                new Employee() { EmployeeId = 14, Name = "Hilario Masterson", DepartementId = 8 },
//                new Employee() { EmployeeId = 15, Name = "Janice Skipper", DepartementId = 5 },
//                new Employee() { EmployeeId = 16, Name = "Keren Gillespi", DepartementId = 9 },
//                new Employee() { EmployeeId = 17, Name = "Linh Leitzel", DepartementId = 2 },
//                new Employee() { EmployeeId = 18, Name = "Rosalia Ayoub", DepartementId = 10 },
//                new Employee() { EmployeeId = 19, Name = "Shawna Hood", DepartementId = 4 },
//                new Employee() { EmployeeId = 20, Name = "Wilfredo Stumpf", DepartementId = 11 },

//                new Employee() { EmployeeId = 21, Name = "Alexandra Brendle", DepartementId = 9 },
//                new Employee() { EmployeeId = 22, Name = "Mainframe PC Development and Practacal Source Code Acquisition Team", DepartementId = 12 },
//                new Employee() { EmployeeId = 23, Name = "Boyce Perales", DepartementId = 11 },
//                new Employee() { EmployeeId = 24, Name = "Alissa Perlman", DepartementId = 3 },
//                new Employee() { EmployeeId = 25, Name = "Latoyia Kremer", DepartementId = 11 },
//                new Employee() { EmployeeId = 26, Name = "Tawna Blackmore", DepartementId = 5 },
//                new Employee() { EmployeeId = 27, Name = "Claudine Valderrama", DepartementId = 7 },
//                new Employee() { EmployeeId = 28, Name = "Katheryn Lepak", DepartementId = 11 },
//                new Employee() { EmployeeId = 29, Name = "Sage Bow", DepartementId = 8 },
//                new Employee() { EmployeeId = 30, Name = "Altha Rudisill", DepartementId = 1 },

//                new Employee() { EmployeeId = 29, Name = "Olympia Vien", DepartementId = 10 },
//                new Employee() { EmployeeId = 29, Name = "Olene Pyron", DepartementId = 13 },
//                new Employee() { EmployeeId = 29, Name = "Delorse Searle", DepartementId = 2 },
//                new Employee() { EmployeeId = 29, Name = "Greta Quigg", DepartementId = 14 },
//                new Employee() { EmployeeId = 29, Name = "Kenneth Bowie", DepartementId = 4 },
//                new Employee() { EmployeeId = 29, Name = "Colton Kranz", DepartementId = 7 },
//                new Employee() { EmployeeId = 29, Name = "Kasie Barclay", DepartementId = 8 },
//                new Employee() { EmployeeId = 29, Name = "Thresa Levins", DepartementId = 2 },
//                new Employee() { EmployeeId = 29, Name = "Diego Hasbrouck", DepartementId = 15 },
//                new Employee() { EmployeeId = 29, Name = "Tomoko Gale", DepartementId = 6 }

//                );

//            base.Seed(context);
//        }
//    }
//}
