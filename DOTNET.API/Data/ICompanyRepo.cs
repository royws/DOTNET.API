using System;
using System.Collections.Generic;
using DOTNET.API.Models;

namespace DOTNET.API.Data
{
    public interface ICompanyRepo
    {
        bool SaveChanges();

        IEnumerable<Company> GetAllCompanies();
        Company GetCompanyById(Guid id);
        void CreateCompany(Company companyToCreate);
        void UpdateCompany(Company companyToUpdate);
        void DeleteCompany(Company companyToDelete);
    }
}
