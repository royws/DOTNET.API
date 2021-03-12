// Object that gets mapped back to the end user
using System;
using System.Collections.Generic;
using DOTNET.API.Models;

namespace DOTNET.API.Dtos
{
    public class CaseReadDto
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public Company Company { get; set; }
        public ICollection<CaseTechnique> CaseTechniques { get; set; }
    }
}
