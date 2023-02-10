using AutoMapper;
using AutoMapper_NET6.Models;

namespace AutoMapper_NET6
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Student, StudentViewModel>()
                   .ForMember(dest => dest.FullName, opt => opt.MapFrom(src =>
                       $"{src.FirstName} {src.LastName}"));
        }
    }
}
