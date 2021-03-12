// Mapping from source object to destination object and vice versa
using AutoMapper;
using DOTNET.API.Dtos;
using DOTNET.API.Models;

namespace DOTNET.API.Profiles
{
    public class CaseTechniquesProfile : Profile
    {
        public CaseTechniquesProfile()
        {
            // Source -> Target
            CreateMap<CaseTechnique, CaseTechniqueReadDto>();
            CreateMap<CaseTechniqueCreateDto, CaseTechnique>();
            CreateMap<CaseTechniqueUpdateDto, CaseTechnique>();
            CreateMap<CaseTechnique, CaseTechniqueUpdateDto>();
        }
    }
}
