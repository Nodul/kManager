using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using kManager.Domain;

namespace kManager.Tests.Domain
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        public void EmployeeConstructor_Valid_True()
        {
            var employee = new Employee()
            {
                Id = 500,
                Name = "Matt Hogan"

            };

            Assert.IsNotNull(employee);
            Assert.AreEqual(500,employee.Id);
            Assert.AreEqual("Matt Hogan", employee.Name);
        }
    }
}
