using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kManager.Domain;
using System.Collections.Generic;

namespace kManager.Tests.Domain
{
    [TestClass]
    public class DepartmentTests
    {
        [TestMethod]
        public void DepartmentConstructor_Valid_True()
        {
            var department = new Department()
            {              
                Id = 5,
                Name = "Accounting",
                Employees = new List<Employee>()
                {
                    new Employee(){Name = "John S", Id = 0},
                    new Employee(){Name = "Barbara S", Id = 1},
                    new Employee(){Name = "Adam Z", Id = 2},

                }
                

            };

            Assert.IsNotNull(department);
            Assert.AreEqual(5, department.Id);
            Assert.AreEqual("Accounting", department.Name);
            Assert.AreEqual(3,department.Employees.Count);
        }
    }
}
