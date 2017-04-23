namespace kManager.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<kManager.Web.Infrastructure.DepartmentDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(kManager.Web.Infrastructure.DepartmentDB context)
        {
            context.Departments.AddOrUpdate(
                d => d.Name,
                new Department() { Name = "Engineering" },
                new Department() { Name = "Sales" },
                new Department() { Name = "Shipping" },
                new Department() { Name = "Human Resources"});
        }
    }
}
