using System;
using System.Collections.Generic;
using DOTNET.API.Models;

namespace DOTNET.API.Data
{
    public interface ICaseRepo
    {
        bool SaveChanges();

        IEnumerable<Case> GetAllCases();
        Case GetCaseById(Guid id);
        void CreateCase(Case caseToCreate);
        void UpdateCase(Case caseToUpdate);
        void DeleteCase(Case caseToDelete);
    }
}
