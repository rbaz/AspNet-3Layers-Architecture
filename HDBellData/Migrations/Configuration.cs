using HDBellData.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDBellData.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<HDBellData.HDBellContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "HDBellData.HDBellContext";
        }

        protected override void Seed(HDBellContext context)
        {

            context.Departments.AddOrUpdate(x => x.DepartmentId,
                new Department() { DepartmentId = 1, DName = "Division of Telecommunications Extranet Development" },
                new Department() { DepartmentId = 2, DName = "Extranet Multimedia Connectivity and Security Division" },
                new Department() { DepartmentId = 3, DName = "Branch of Extranet Implementation" },
                new Department() { DepartmentId = 4, DName = "Branch of Intranet Computer Maintenance and E-Commerce PC Programming" },
                new Department() { DepartmentId = 5, DName = "Wireless Extranet Backup Team" },
                new Department() { DepartmentId = 6, DName = "Database Programming Branch" },
                new Department() { DepartmentId = 7, DName = "Hardware Backup Department" },
                new Department() { DepartmentId = 8, DName = "Multimedia Troubleshooting and Maintenance Team" },
                new Department() { DepartmentId = 9, DName = "Office of Statistical Data Connectivity" },
                new Department() { DepartmentId = 10, DName = "Division of Application Security" },
                new Department() { DepartmentId = 11, DName = "Network Maintenance and Multimedia Implementation Committee" },
                new Department() { DepartmentId = 12, DName = "PC Maintenance Department" },
                new Department() { DepartmentId = 13, DName = "Bureau of Business-Oriented PC Backup and Wireless Telecommunications Control" },
                new Department() { DepartmentId = 14, DName = "Software Technology and Networking Department" }
                );

            context.Employees.AddOrUpdate(x => x.EmployeeId,
                new Employee() { EmployeeId = 1, Name = "Roma Marcell", DepartmentId = 1 },
                new Employee() { EmployeeId = 2, Name = "Hugo Wess", DepartmentId = 2 },
                new Employee() { EmployeeId = 3, Name = "Kelvin Lahr", DepartmentId = 3 },
                new Employee() { EmployeeId = 4, Name = "Janelle Newberg", DepartmentId = 1 },
                new Employee() { EmployeeId = 5, Name = "Mellie Lombard", DepartmentId = 4 },
                new Employee() { EmployeeId = 6, Name = "Reita Abshire", DepartmentId = 5 },
                new Employee() { EmployeeId = 7, Name = "Dalila Vickrey", DepartmentId = 6 },
                new Employee() { EmployeeId = 8, Name = "Idella Dallman", DepartmentId = 3 },
                new Employee() { EmployeeId = 9, Name = "Farah Eldridge", DepartmentId = 7 },
                new Employee() { EmployeeId = 10, Name = "Lana Montes", DepartmentId = 7 },

                new Employee() { EmployeeId = 11, Name = "Leola Thornburg", DepartmentId = 2 },
                new Employee() { EmployeeId = 12, Name = "Marcelo Paris", DepartmentId = 6 },
                new Employee() { EmployeeId = 13, Name = "Ione Tomlin", DepartmentId = 8 },
                new Employee() { EmployeeId = 14, Name = "Hilario Masterson", DepartmentId = 8 },
                new Employee() { EmployeeId = 15, Name = "Janice Skipper", DepartmentId = 5 },
                new Employee() { EmployeeId = 16, Name = "Keren Gillespi", DepartmentId = 9 },
                new Employee() { EmployeeId = 17, Name = "Linh Leitzel", DepartmentId = 2 },
                new Employee() { EmployeeId = 18, Name = "Rosalia Ayoub", DepartmentId = 10 },
                new Employee() { EmployeeId = 19, Name = "Shawna Hood", DepartmentId = 4 },
                new Employee() { EmployeeId = 20, Name = "Wilfredo Stumpf", DepartmentId = 11 },

                new Employee() { EmployeeId = 21, Name = "Alexandra Brendle", DepartmentId = 9 },
                new Employee() { EmployeeId = 22, Name = "Mainframe PC Development and Practacal Source Code Acquisition Team", DepartmentId = 12 },
                new Employee() { EmployeeId = 23, Name = "Boyce Perales", DepartmentId = 11 },
                new Employee() { EmployeeId = 24, Name = "Alissa Perlman", DepartmentId = 3 },
                new Employee() { EmployeeId = 25, Name = "Latoyia Kremer", DepartmentId = 11 },
                new Employee() { EmployeeId = 26, Name = "Tawna Blackmore", DepartmentId = 5 },
                new Employee() { EmployeeId = 27, Name = "Claudine Valderrama", DepartmentId = 7 },
                new Employee() { EmployeeId = 28, Name = "Katheryn Lepak", DepartmentId = 11 },
                new Employee() { EmployeeId = 29, Name = "Sage Bow", DepartmentId = 8 },
                new Employee() { EmployeeId = 30, Name = "Altha Rudisill", DepartmentId = 1 },

                new Employee() { EmployeeId = 29, Name = "Olympia Vien", DepartmentId = 10 },
                new Employee() { EmployeeId = 29, Name = "Olene Pyron", DepartmentId = 13 },
                new Employee() { EmployeeId = 29, Name = "Delorse Searle", DepartmentId = 2 },
                new Employee() { EmployeeId = 29, Name = "Greta Quigg", DepartmentId = 14 },
                new Employee() { EmployeeId = 29, Name = "Kenneth Bowie", DepartmentId = 4 },
                new Employee() { EmployeeId = 29, Name = "Colton Kranz", DepartmentId = 7 },
                new Employee() { EmployeeId = 29, Name = "Kasie Barclay", DepartmentId = 8 },
                new Employee() { EmployeeId = 29, Name = "Thresa Levins", DepartmentId = 2 },
                new Employee() { EmployeeId = 29, Name = "Diego Hasbrouck", DepartmentId = 14 },
                new Employee() { EmployeeId = 29, Name = "Tomoko Gale", DepartmentId = 6 }

                );

            base.Seed(context);
        }
    }
}
