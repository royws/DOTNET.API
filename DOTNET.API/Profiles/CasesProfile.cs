// Mapping from source object to destination object and vice versa
using AutoMapper;
using DOTNET.API.Dtos;
using DOTNET.API.Models;

namespace DOTNET.API.Profiles
{
    public class CasesProfile : Profile
    {
        public CasesProfile()
        {
            // Source -> Target
            CreateMap<Case, CaseReadDto>();
            CreateMap<CaseCreateDto, Case>();
            CreateMap<CaseUpdateDto, Case>();
            CreateMap<Case, CaseUpdateDto>();
        }
    }
}
