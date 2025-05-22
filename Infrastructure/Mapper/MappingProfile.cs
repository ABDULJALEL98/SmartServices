using AutoMapper;
using SmartServices.Dtos;
using SmartServices.Models;

namespace SmartServices.Infrastructure.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<CategoryDtoForInsertion, Category>();
            CreateMap<CategoryDtoForUpdate, Category>().ReverseMap();
            CreateMap<ServiceDtoForInsertion, Service>();
            CreateMap<ServiceDtoForUpdate, Service>().ReverseMap();


        }
    }
}
