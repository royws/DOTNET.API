using System.ComponentModel.DataAnnotations;

namespace DOTNET.API.Dtos
{
    public class CompanyCreateDto
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
    }
}
