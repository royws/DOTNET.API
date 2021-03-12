using System;
using System.ComponentModel.DataAnnotations;

namespace DOTNET.API.Dtos
{
    public class CaseTechniqueCreateDto
    {
        [Required]
        public Guid CaseId { get; set; }

        [Required]
        public Guid TechniqueId { get; set; }
    }
}
