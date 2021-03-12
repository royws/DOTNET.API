using System;
using System.Collections.Generic;
using DOTNET.API.Models;

namespace DOTNET.API.Data
{
    public interface ICaseTechniqueRepo
    {
        bool SaveChanges();

        IEnumerable<CaseTechnique> GetAllCaseTechniques();
        CaseTechnique GetCaseTechniqueById(Guid id);
        void CreateCaseTechnique(CaseTechnique caseTechniqueToCreate);
        void UpdateCaseTechnique(CaseTechnique caseTechniqueToUpdate);
        void DeleteCaseTechnique(CaseTechnique caseTechniqueToDelete);
    }
}
