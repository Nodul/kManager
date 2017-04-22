using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kManager.Domain
{
    public interface IDepartmentDataSource
    {
        IQueryable<Employee> Employees { get;}
        IQueryable<Department> Departments { get; }
    }
}
