using kManager.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace kManager.Web.Infrastructure
{
    public class DepartmentDB : DbContext, IDepartmentDataSource
    {
        //Default connection because it was created on project creation in Web.config
        public DepartmentDB() : base("DefaultConnection")
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }


        IQueryable<Employee> IDepartmentDataSource.Employees
        {
            get { return Employees; }
        }

        IQueryable<Department> IDepartmentDataSource.Departments
        {
            get { return Departments; }
        }
    }
}