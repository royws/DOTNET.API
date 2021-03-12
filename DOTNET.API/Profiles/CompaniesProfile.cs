// Mapping from source object to destination object and vice versa
using AutoMapper;
using DOTNET.API.Dtos;
using DOTNET.API.Models;

namespace DOTNET.API.Profiles
{
    public class CompaniesProfile : Profile
    {
        public CompaniesProfile()
        {
            // Source -> Target
            CreateMap<Company, CompanyReadDto>();
            CreateMap<CompanyCreateDto, Company>();
            CreateMap<CompanyUpdateDto, Company>();
            CreateMap<Company, CompanyUpdateDto>();
        }
    }
}
