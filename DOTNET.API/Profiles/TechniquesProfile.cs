// Mapping from source object to destination object and vice versa
using AutoMapper;
using DOTNET.API.Dtos;
using DOTNET.API.Models;

namespace DOTNET.API.Profiles
{
    public class TechniquesProfile : Profile
    {
        public TechniquesProfile()
        {
            // Source -> Target
            CreateMap<Technique, TechniqueReadDto>();
            CreateMap<TechniqueCreateDto, Technique>();
            CreateMap<TechniqueUpdateDto, Technique>();
            CreateMap<Technique, TechniqueUpdateDto>();
        }
    }
}
