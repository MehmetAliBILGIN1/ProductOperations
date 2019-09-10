using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductOperations.Models.Manager
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Company> Companys { get; set; }

        public DatabaseContext()
        {
            Database.SetInitializer<DatabaseContext>(new Creator());
        }
    }



    public class Creator : CreateDatabaseIfNotExists<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            List<Company> companyList = new List<Company>();
                for(int i=0; i<=5; i++)
            {
                Company company = new Company();
                company.CompanyName = FakeData.NameData.GetCompanyName();
                company.Price = FakeData.NumberData.GetNumber(100, 10000);
                companyList.Add(company);
                context.Companys.Add(company);
            }

            context.SaveChanges();
        }
    }
}